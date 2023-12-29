
using QLPKNK_App;
using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class Treatment : Form
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public NhaSiDTO ns=null;
        public Admin_StaffDTO ad = null;
        public Treatment()
        {
            InitializeComponent();
            this.Text = "Treatement";
        }
        public Treatment(Admin_StaffDTO ad)
        {
            InitializeComponent();
            this.ad = ad;
            TreatmentTable.Columns["ReserveReExam"].Visible = false;
        }
        public Treatment(NhaSiDTO ns)
        {
            InitializeComponent();
            this.ns = ns;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BenhNhanBUS bnBUS=new BenhNhanBUS();
            IList<BenhNhanDTO> DSBN = bnBUS.layDSBenhNhan();
            patientSearch.DisplayMember = "Name";
            patientSearch.ValueMember = "Id";
            patientSearch.Items.AddRange(DSBN.ToArray());
            patientSearch.KeyDown += new KeyEventHandler(keyDownEvt);
            if(patientSearch.Items.Count>0)
            {
                patientSearch.SelectedIndex = 0;
            }
        }
        private void keyDownEvt(object sender, EventArgs e)
        {
            patientSearch.DroppedDown = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                int tId= Convert.ToInt32(TreatmentTable.Rows[e.RowIndex].Cells["ID"].Value);
                int pId= Convert.ToInt32(TreatmentTable.Rows[e.RowIndex].Cells["PatientID"].Value);
                AddSchedule addReSchedule=new AddSchedule(tId,pId,ns);
                addReSchedule.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                //int tId = Convert.ToInt32(TreatmentTable.Rows[e.RowIndex].Cells["ID"].Value);
                string str = TreatmentTable.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                using (Prescription p = new Prescription(str))
                {
                    p.ShowDialog();
                }
            }

        }

        private void searchPatient_Click(object sender, EventArgs e)
        {
            int pID = ((BenhNhanDTO)patientSearch.SelectedItem).id;
            TreatmentTable.Rows.Clear();
            HienThiKHDT(pID);
        }
        private void HienThiKHDT(int  pID)
        {
            KHDieuTriBUS kHDieuTriBUS = new KHDieuTriBUS();
            IList<KHDieuTriDTO> dsKHDT = kHDieuTriBUS.layDsKHDieuTriTheoBN(pID);
            foreach(KHDieuTriDTO khdt in dsKHDT)
            {
                TreatmentTable.Rows.Add("","",khdt.id, khdt.department, khdt.patient,khdt.pat_name, khdt.dentist,khdt.den_name, khdt.assistant,khdt.ass_name, khdt.description, khdt.date, khdt.note, khdt.method, khdt.tooth_name, khdt.state, khdt.total);
            }
        }
    }
}
