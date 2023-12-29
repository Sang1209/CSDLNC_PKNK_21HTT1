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
using QLPKNK_App.BUS;
using QLPKNK_App.DTO;

namespace QLPKNK_App
{
    public partial class AddTreatment : Form
    {
        public AddTreatment()
        {
            InitializeComponent();
        }
        public AddTreatment(int pID)
        {
            InitializeComponent();
            LoadData(pID);
        }
        private void LoadData(int pID)
        {
            PatientID.Value = pID;

            HoSoDTO hs = new HoSoDTO();
            HoSoBUS hsBUS = new HoSoBUS();
            hs = hsBUS.layThongTinHoSO(pID);
            PatientName.Text = hs.name;

            DepartmentBUS depBUS = new DepartmentBUS();
            IList<DepartmentDTO> dep = depBUS.LayDSDepartment();
            DepartmentCB.DataSource = dep;
            DepartmentCB.DisplayMember = "address";
            DepartmentCB.ValueMember = "id";

            NhaSiBUS nsBUS = new NhaSiBUS();
            IList<NhaSiDTO> ns = nsBUS.layDSNhaSi();
            DentistCB.DataSource = ns;
            DentistCB.DisplayMember = "name";
            DentistCB.ValueMember = "username";

            IList<NhaSiDTO> ass = nsBUS.layDSNhaSi();
            NhaSiDTO empty = new NhaSiDTO();
            ass.Insert(0, empty);
            AssistantCB.DataSource = ass;
            AssistantCB.DisplayMember = "name";
            AssistantCB.ValueMember = "username";

            PTDieuTriBUS ptBUS = new PTDieuTriBUS();
            IList<PTDieuTriDTO> pt = ptBUS.layDSPhuongThucDT();
            MethodCB.DataSource = pt;
            MethodCB.DisplayMember = "name";
            MethodCB.ValueMember = "id";

            ToothBUS tBUS = new ToothBUS();
            IList<ToothDTO> t = tBUS.layDSRang();
            ToothCB.DataSource = t;
            ToothCB.DisplayMember = "name";
            ToothCB.ValueMember = "id";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int patient = (int)PatientID.Value;
            int department = (int)DepartmentCB.SelectedValue;
            string dentist = DentistCB.SelectedValue.ToString();
            string assistant = AssistantCB.SelectedIndex.ToString();
            string description = Description.Text;
            string note = Note.Text;
            int method = (int)MethodCB.SelectedValue;
            int tooth = (int)ToothCB.SelectedValue;

            KHDieuTriBUS dtBUS = new KHDieuTriBUS();
            dtBUS.themDieuTri(patient, department, dentist, assistant, description, note, method, tooth);
        }
    }
}
