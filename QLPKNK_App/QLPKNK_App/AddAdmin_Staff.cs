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

namespace QLPKNK_App
{
    public partial class AddAdmin_Staff : Form
    {
        public AddAdmin_Staff()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = AdminUsername.Text;
            string password = AdminPassword.Text;
            string name = AdminName.Text;
            bool gender;
            if (AdminGender.SelectedItem.ToString() == "Male")
                gender = true;
            else gender = false;
            bool type;
            if (AdminType.SelectedItem.ToString() == "Admin")
                type = true;
            else type = false;
            string phone = AdminPhone.Text;
            string email = AdminEmail.Text;
            string address = AdminAddress.Text;

            Admin_StaffBUS admin_staffBUS = new Admin_StaffBUS();
            admin_staffBUS.themAdmin_NhanVien(username, password, name, gender, type, phone, email, address);
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
