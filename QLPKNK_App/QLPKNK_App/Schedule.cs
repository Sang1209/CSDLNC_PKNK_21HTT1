using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPKNK_App
{
    public partial class Schedule : Form
    {
        public Admin_StaffDTO adst = null;
        public NhaSiDTO ns= null;
        public Schedule()
        {
            InitializeComponent();
        }
        public Schedule(Admin_StaffDTO adst)
        {
            InitializeComponent();
            this.adst = adst;
            createSchedule.Hide();
            scheduleTable.Columns["Accept"].Visible = false;
            scheduleTable.Columns["Cancel"].Visible = false;
            scheduleTable.Columns["Update"].Visible = false;
        }
        public Schedule(NhaSiDTO ns)
        {
            InitializeComponent();
            this.ns = ns;
            createSchedule.Show();
            scheduleTable.Columns["Reserve"].Visible = false;
        }
        private void keyDownEvt(object sender, EventArgs e)
        {
            DentistCB.DroppedDown = false;
            DepartmentCB.DroppedDown = false;
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            DentistCB.DisplayMember = "name";
            DepartmentCB.DisplayMember = "address";
            if (ns!=null)
            {
                DentistCB.Items.Add(ns);
                DentistCB.SelectedIndex = 0;
                DentistCB.Enabled = false;
            }
            else
            {
                DentistCB.KeyDown += new KeyEventHandler(keyDownEvt);
                NhaSiBUS nhaSi = new NhaSiBUS();
                IList<NhaSiDTO> dsNS = nhaSi.layDSNhaSi();
                DentistCB.Items.Add(new NhaSiDTO() { username = "-1", name = "All" });
                DentistCB.Items.AddRange(dsNS.ToArray());
                if (DentistCB.Items.Count > 0)
                {
                    DentistCB.SelectedIndex = 0;
                }
            }
            DepartmentCB.KeyDown += new KeyEventHandler(keyDownEvt);
            DepartmentBUS departmentBUS = new DepartmentBUS();
            IList<DepartmentDTO> dsDep = departmentBUS.LayDSDepartment();
            DepartmentCB.Items.Add(new DepartmentDTO() { id = -1, address = "All" });
            DepartmentCB.Items.AddRange(dsDep.ToArray());
            if (DepartmentCB.Items.Count > 0)
            {
                DepartmentCB.SelectedIndex = 0;
            }
            PatientCB.DisplayMember = "name";
            BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
            IList<BenhNhanDTO> dsBN = benhNhanBUS.layDSBenhNhan();
            PatientCB.Items.Add(new BenhNhanDTO() { id = -1, name = "All" });
            PatientCB.Items.AddRange(dsBN.ToArray());
            if (PatientCB.Items.Count > 0)
            {
                PatientCB.SelectedIndex = 0;
            }
            DepartmentCB.SelectedIndexChanged += new EventHandler(refreshData);
            PatientCB.SelectedIndexChanged += new EventHandler(refreshData);
            DentistCB.SelectedIndexChanged += new EventHandler(refreshData);
            //treatmentID.SelectedIndexChanged += new EventHandler(refreshData);
            DatePicker.ValueChanged += new EventHandler(refreshData);
            loadData();
        }
        private void refreshData(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            scheduleTable.Rows.Clear();
            LichHenBUS lichHenBUS = new LichHenBUS();
            //int s = searchBy.SelectedIndex;
            string dentist = string.IsNullOrEmpty(DentistCB.Text)?"-1":((NhaSiDTO)DentistCB.SelectedItem).username;
            int pId = string.IsNullOrEmpty(PatientCB.Text) ? -1 : ((BenhNhanDTO)PatientCB.SelectedItem).id;
            int dId = string.IsNullOrEmpty(DepartmentCB.Text) ? -1 : ((DepartmentDTO)DepartmentCB.SelectedItem).id;
            //int tId = (int)treatmentID.Value;
            DateTime date;
            IList<LichHenDTO> dsLichHen = new List<LichHenDTO>();
            if (!enableDate.Checked)
            {
                dsLichHen = lichHenBUS.layDSLichHenTrongNgay(pId, dId, dentist);
            }
            else if (enableDate.Checked)
            {
                date = DatePicker.Value;
                dsLichHen = lichHenBUS.layDSLichHenTheoNgay(pId, dId, dentist, date);
            }
            foreach (LichHenDTO lh in dsLichHen)
            {
                scheduleTable.Rows.Add(lh.accept, "", "", "", "", "", lh.date.ToShortDateString(), lh.shiftId, lh.start, lh.finish, lh.dentist, lh.den_name, lh.patient, lh.pat_name, lh.assistant, lh.ass_name, lh.type, lh.depId, lh.DepAddress);
            }
        }

        private void createSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule(ns);
            addSchedule.FormClosing += new FormClosingEventHandler(Schedule_Load);
            addSchedule.ShowDialog();
        }

        private void scheduleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dentist=scheduleTable.Rows[e.RowIndex].Cells["Dentist"].Value.ToString();
            int shiftID = Convert.ToInt32(scheduleTable.Rows[e.RowIndex].Cells["Shift"].Value);
            DateTime date = DateTime.Parse(scheduleTable.Rows[e.RowIndex].Cells["Date"].Value.ToString());
            int pId= Convert.ToInt32(scheduleTable.Rows[e.RowIndex].Cells["PatientID"].Value);
            bool accept = Convert.ToBoolean(scheduleTable.Rows[e.RowIndex].Cells["Accepted"].Value);
            LichHenBUS lichHenBUS = new LichHenBUS();
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                if(pId!=0)
                {
                    MessageBox.Show(this, "Cannot delete a schedule that already been reserved!");
                }
                lichHenBUS.xoaLichHen(date, shiftID, dentist);
                loadData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DateTime curdate = DateTime.Now;
                if(date<=curdate.AddMinutes(30))
                {
                    MessageBox.Show(this, "This schedule cannot be updated anymore!");
                    return;
                }
                UpdateScheduleForm editFrm = new UpdateScheduleForm(date,shiftID,dentist);
                editFrm.FormClosing += new FormClosingEventHandler(Schedule_Load);
                editFrm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                if (pId != 0)
                {
                    MessageBox.Show(this, "This schedule is already reserved!");
                    return;
                }
                DateTime curdate = DateTime.Now;
                if (date <= curdate.AddMinutes(10))
                {
                    MessageBox.Show(this, "This schedule cannot be reserve anymore!");
                    return;
                }
                lichHenBUS.datLichHen(date, shiftID, dentist, pId);
                loadData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                if (!accept)
                {
                    MessageBox.Show(this, "This schedule is not accepted so cannot be cancelled!");
                    return;
                }
                DateTime curdate = DateTime.Now;
                if (date <= curdate.AddMinutes(30))
                {
                    MessageBox.Show(this, "This schedule cannot be cancel anymore!");
                    return;
                }
                lichHenBUS.huyDatLichHen(date, shiftID, dentist);
                loadData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                if(accept)
                {
                    MessageBox.Show(this, "This schedule is already accepted!");
                }
                lichHenBUS.nhanLichHen(date, shiftID, dentist);
                loadData();
            }
        }

        private void enableDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePicker.Enabled = enableDate.Checked;
        }

        private void PatientCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
