using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            role.Items.Add("Admin");
            role.Items.Add("Staff");
            role.Items.Add("Dentist");
            role.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = role.SelectedIndex;
            string u=username.Text;
            string p=password.Text;
            LoginBUS login = new LoginBUS();
            if(r == 0)
            {
                Admin_StaffDTO ad= login.checkLoginAdmin(u, p);
                if (ad != null)
                {
                    Home h = new Home(ad);
                    h.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Wrong username or password!");
                }
            }
            else if (r == 1)
            {
                Admin_StaffDTO st= login.checkLoginStaff(u, p);
                if (st != null)
                {
                    Home h = new Home(st);
                    h.ShowDialog();
                    this.Close();
                }
                else
                {
                        MessageBox.Show(this, "Wrong username or password!");
                }
            }
            else if(r==2)
            {
                NhaSiDTO ns = login.checkLoginDentist(u, p);
                if (ns != null)
                {
                    Home h = new Home(ns);
                    h.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Wrong username or password!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
