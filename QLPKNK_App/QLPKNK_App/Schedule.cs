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
        }
        public Schedule(NhaSiDTO ns)
        {
            InitializeComponent();
            this.ns = ns;
            createSchedule.Show();
        }
        private void checkSearch(object sender, EventArgs e)
        {
            searchUsername.Text = "";
            searchID.Value = 0;
            if (searchBy.SelectedIndex == 1||searchBy.SelectedIndex==3)
            {
                searchUsername.Hide();
                searchID.Show();
                filterTitle.Text = "Enter ID: ";
                filterTitle.Show();
            }
            else if (searchBy.SelectedIndex == 2)
            {
                searchID.Hide();
                searchUsername.Show();
                filterTitle.Text = "Enter username: ";
                filterTitle.Show();
            }
            else if(searchBy.SelectedIndex==0)
            {
                searchID.Hide();
                searchUsername.Hide();
                filterTitle.Hide();
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            searchBy.Items.Add("All");
            searchBy.Items.Add("Patient");
            searchBy.Items.Add("Dentist");
            searchBy.Items.Add("Department");
            searchBy.SelectedIndex = 0;
            searchBy.SelectedIndexChanged += new EventHandler(checkSearch);
            searchID.Hide();
            searchUsername.Hide();
            filterTitle.Hide();
            scheduleTable.Rows.Clear();
            LichHenBUS lichHenBUS = new LichHenBUS();
            IList<LichHenDTO> dsLichHen = lichHenBUS.layDSLichHenTrongNgay(0,0,"");
            foreach (LichHenDTO lh in dsLichHen)
            {
                scheduleTable.Rows.Add(lh.date.ToShortDateString(), lh.shiftId, lh.start, lh.finish, lh.dentist, lh.patient, lh.assistant, lh.type, lh.depId,lh.DepAddress);
            }
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            scheduleTable.Rows.Clear();
            LichHenBUS lichHenBUS = new LichHenBUS();
            int id = Convert.ToInt32(searchID.Value);
            string username = searchUsername.Text;
            IList<LichHenDTO> dsLichHen = lichHenBUS.layDSLichHenTrongNgay(searchBy.SelectedIndex, id, username);
            foreach (LichHenDTO lh in dsLichHen)
            {
                scheduleTable.Rows.Add(lh.date.ToShortDateString(), lh.shiftId, lh.start, lh.finish, lh.dentist, lh.patient, lh.assistant, lh.type,lh.depId,lh.DepAddress);
            }
        }

        private void createSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule(ns);
            addSchedule.ShowDialog();
        }
    }
}
