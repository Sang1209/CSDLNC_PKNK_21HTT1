using buhbuhlmao;
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
    public partial class Home : Form
    {
        public Admin_StaffDTO adst = null;
        public NhaSiDTO ns=null;
        public Home()
        {
            InitializeComponent();
        }
        public Home(Admin_StaffDTO adst)
        {
            InitializeComponent();
            this.adst = adst;
            if(adst.admin)
            {
                Text = "Admin home page";
            }
            else
            {
                Text = "Staff home page";
            }
            
        }
        public Home(NhaSiDTO ns)
        {
            InitializeComponent();
            this.ns= ns;
            Text = "Dentist home page";
            button4.Hide();
            depBtn.Hide();
        }

        private void treatmentBtn_Click(object sender, EventArgs e)
        {
            if(ns!=null)
            {
                Treatment t = new Treatment(ns);
                t.Show();
            }
            else if(adst!=null)
            {
                Treatment t = new Treatment(adst);
                t.Show();
            }
            
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            Payment p =new Payment();
            p.Show();
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            if (ns != null)
            {
                Schedule s = new Schedule(ns);
                s.Show();
            }
            else if (adst != null)
            {
                Schedule s = new Schedule(adst);
                s.Show();
            }
        }

        private void depBtn_Click(object sender, EventArgs e)
        {
            Department d=new Department();
            d.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.ShowDialog();
            this.Close();
        }
    }
}
