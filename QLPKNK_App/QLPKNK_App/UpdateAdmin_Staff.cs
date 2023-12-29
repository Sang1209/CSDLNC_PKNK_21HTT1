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
    public partial class UpdateAdmin_Staff : Form
    {
        public UpdateAdmin_Staff()
        {
            InitializeComponent();
        }

        public UpdateAdmin_Staff(string username)
        {
            InitializeComponent();
            loadData(username);
        }

        private void loadData(string username)
        {
            Admin_StaffBUS nvBUS = new Admin_StaffBUS();
            Admin_StaffDTO nv = nvBUS.timNhanVien(username);

            StaffUsername.Text = nv.username;
            StaffPassword.Text = nv.password;
            StaffName.Text = nv.name;
            StaffPhone.Text = nv.phone;
            StaffEmail.Text = nv    .email;
            StaffAddress.Text = nv.address;
            StaffGender.SelectedIndex = (nv.gender ? 0 : 1);
            StaffRole.SelectedIndex = (nv.admin ? 1 : 0);
        }

        private void UpdateAdmin_Staff_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string username = StaffUsername.Text;
            string password = StaffPassword.Text;
            string name = StaffName.Text;
            string phone = StaffPhone.Text;
            string email = StaffEmail.Text;
            string address = StaffAddress.Text;
            bool gender = (StaffGender.SelectedIndex == 0 ? true : false);
            bool admin = (StaffRole.SelectedIndex == 0 ? false : true);

            Admin_StaffBUS nvBUS = new Admin_StaffBUS();
            nvBUS.capNhatNhanVien(username, password, name, phone, email, address, gender, admin);
        }
    }
}
