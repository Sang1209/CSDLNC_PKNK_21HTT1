using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace QLPKNK_App
{
    public partial class AddDentist : Form
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public AddDentist()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void AddDentist_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxData()
        {
            DepartmentBUS departmentBUS = new DepartmentBUS();
            DataTable dsDepartment = departmentBUS.LayDSDepartment();

            DentistDepartment.DataSource = dsDepartment;
            DentistDepartment.DisplayMember = "address";
            DentistDepartment.ValueMember = "id";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DentistUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
