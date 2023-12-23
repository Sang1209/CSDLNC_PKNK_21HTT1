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
        private void checkSearch(object sender, EventArgs e)
        {
            content.Items.Clear();
            if (searchBy.SelectedIndex == 3)
            {
                content.DisplayMember = "address";
                DepartmentBUS departmentBUS = new DepartmentBUS();
                IList<DepartmentDTO> dsDep = departmentBUS.LayDSDepartment();
                content.Items.AddRange(dsDep.ToArray());
                if(content.Items.Count>0)
                {
                    content.SelectedIndex = 0;
                }
                filterTitle.Text = "Department";
                filterTitle.Show();
                content.Show();
            }
            else if (searchBy.SelectedIndex == 1)
            {
                content.DisplayMember = "name";
                BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
                IList<BenhNhanDTO> dsBN = benhNhanBUS.layDSBenhNhan();
                content.Items.AddRange(dsBN.ToArray());
                if (content.Items.Count > 0)
                {
                    content.SelectedIndex = 0;
                }
                filterTitle.Text = "Patient:";
                filterTitle.Show();
                content.Show();
            }
            else if (searchBy.SelectedIndex == 2)
            {
                content.DisplayMember = "name";
                NhaSiBUS nhaSi = new NhaSiBUS();
                IList<NhaSiDTO> dsNS = nhaSi.layDSNhaSi();
                content.Items.AddRange(dsNS.ToArray());
                if (content.Items.Count > 0)
                {
                    content.SelectedIndex = 0;
                }
                filterTitle.Text = "Dentist:";
                filterTitle.Show();
                content.Show();
            }
            else if(searchBy.SelectedIndex==0)
            {
                filterTitle.Hide();
                content.Hide();
            }
        }
        private void keyDownEvt(object sender, EventArgs e)
        {
            content.DroppedDown = false;
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            
            searchBy.Items.Add("All");
            searchBy.Items.Add("Patient");
            searchBy.Items.Add("Dentist");
            searchBy.Items.Add("Department");
            searchBy.SelectedIndex = 0;
            searchBy.SelectedIndexChanged += new EventHandler(checkSearch);
            content.KeyDown += new KeyEventHandler(keyDownEvt);
            content.Hide();
            filterTitle.Hide();
            scheduleTable.Rows.Clear();
        }
        private void loadData()
        {
            scheduleTable.Rows.Clear();
            LichHenBUS lichHenBUS = new LichHenBUS();
            IList<LichHenDTO> dsLichHen = lichHenBUS.layDSLichHenTrongNgay(0, 0, "");
            foreach (LichHenDTO lh in dsLichHen)
            {
                scheduleTable.Rows.Add(lh.date.ToShortDateString(), lh.shiftId, lh.start, lh.finish, lh.dentist, lh.patient, lh.assistant, lh.type, lh.depId, lh.DepAddress);
            }
        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            scheduleTable.Rows.Clear();
            LichHenBUS lichHenBUS = new LichHenBUS();
            int s = searchBy.SelectedIndex;
            int id=0;
            string username=null;
            if(s == 1)
            {
                id = ((BenhNhanDTO)content.SelectedItem).id;
            }
            else if (s==2)
            {
                username=((NhaSiDTO)content.SelectedItem).username;
            }
            else if (s==3)
            {
                id = ((DepartmentDTO)content.SelectedItem).id;
            }
            IList<LichHenDTO> dsLichHen = lichHenBUS.layDSLichHenTrongNgay(s, id, username);
            foreach (LichHenDTO lh in dsLichHen)
            {
                scheduleTable.Rows.Add("","","","","",lh.date.ToShortDateString(), lh.shiftId, lh.start, lh.finish, lh.dentist,lh.den_name, lh.patient,lh.pat_name, lh.assistant,lh.ass_name, lh.type, lh.depId, lh.DepAddress,lh.accept);
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if(pId!=0)
                {
                    MessageBox.Show(this, "Cannot delete a schedule that already been reserved!");
                }
                lichHenBUS.xoaLichHen(date, shiftID, dentist);
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                UpdateScheduleForm editFrm = new UpdateScheduleForm(date,shiftID,dentist);
                editFrm.FormClosing += new FormClosingEventHandler(Schedule_Load);
                editFrm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                if (pId != 0)
                {
                    MessageBox.Show(this, "This schedule is already reserved!");
                }
                lichHenBUS.datLichHen(date, shiftID, dentist, pId);
                loadData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                if (!accept)
                {
                    MessageBox.Show(this, "This schedule is not accepted so cannot be cancelled!");
                }
                lichHenBUS.huyDatLichHen(date, shiftID, dentist);
                loadData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                if(accept)
                {
                    MessageBox.Show(this, "This schedule is already accepted!");
                }
                lichHenBUS.nhanLichHen(date, shiftID, dentist);
                loadData();
            }
        }
    }
}
