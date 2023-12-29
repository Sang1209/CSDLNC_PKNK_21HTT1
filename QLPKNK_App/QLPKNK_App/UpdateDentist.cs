using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPKNK_App.BUS;
using QLPKNK_App.DTO;

namespace QLPKNK_App
{
    public partial class UpdateDentist : Form
    {
        public UpdateDentist()
        {
            InitializeComponent();
        }

        public UpdateDentist(string username)
        {
            InitializeComponent();
            loadData(username);
        }

        private void loadData(string username)
        {
            DepartmentBUS depBUS = new DepartmentBUS();
            IList<DepartmentDTO> dep = depBUS.LayDSDepartment();
            DentistDepartment.DataSource = dep;
            DentistDepartment.DisplayMember = "address";
            DentistDepartment.ValueMember = "id";

            NhaSiBUS nsBUS = new NhaSiBUS();
            NhaSiDTO ns = nsBUS.timNhaSi(username);

            DentistUsername.Text = ns.username;
            DentistPassword.Text = ns.password;
            DentistName.Text = ns.name;
            DentistPhone.Text = ns.phone;
            DentistEmail.Text = ns.email;
            DentistAddress.Text = ns.address;
            DentistGender.SelectedIndex = (ns.gender ? 0 : 1);
            DentistDepartment.SelectedIndex = ns.depID - 1;
        }

        private void UpdateDentist_Load(object sender, EventArgs e)
        {
            string username = DentistUsername.Text;
            string password = DentistPassword.Text;
            string name = DentistName.Text;
            string phone = DentistPhone.Text;
            string email = DentistEmail.Text;
            string address = DentistAddress.Text;
            bool gender = (DentistGender.SelectedIndex == 0 ? true : false);
            int depID = (int)DentistDepartment.SelectedValue;

            NhaSiBUS nsBUS = new NhaSiBUS();
            nsBUS.capNhatNhaSi(username, password, name, phone, email, address, gender, depID);
        }
    }
}
