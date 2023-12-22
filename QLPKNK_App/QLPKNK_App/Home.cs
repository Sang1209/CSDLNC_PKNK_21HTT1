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
            this.Text= "Home";
            treatmentBtn.Click += new EventHandler((s, e) => { 
            
            });
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
        }

        private void treatmentBtn_Click(object sender, EventArgs e)
        {
            Treatment t=new Treatment();
            t.ShowDialog();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            Payment p =new Payment();
            p.ShowDialog();
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            Schedule s=new Schedule();
            s.ShowDialog();
        }
    }
}
