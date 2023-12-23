using QLPKNK_App.BUS;
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
    public partial class AddEditDepartment : Form
    {
        public AddEditDepartment()
        {
            InitializeComponent();
            title.Text = "Add new department";
            btn.Text = "Add";
        }
        public AddEditDepartment(int id,string dep)
        {
            InitializeComponent();
            title.Text = "Update department";
            depID.Value = id;
            depID.Enabled = false;
            btn.Text = "Update";
            address.Text = dep;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DepartmentBUS departmentBUS = new DepartmentBUS();
            int id = (int)depID.Value;
            string dep=address.Text;
            if(btn.Text == "Add") 
            {
                departmentBUS.themCoSo(id, dep);
            }
            else if(btn.Text =="Update")
            {
                departmentBUS.capNhatCoSo(id, dep);
            }
            Close();
        }
    }
}
