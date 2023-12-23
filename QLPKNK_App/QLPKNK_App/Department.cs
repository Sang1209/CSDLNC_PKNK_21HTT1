using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            departmentTable.Rows.Clear();
            DepartmentBUS departmentBUS = new DepartmentBUS();
            IList<DepartmentDTO> dsDep = departmentBUS.LayDSDepartment();
            foreach (DepartmentDTO dep in dsDep)
            {
                departmentTable.Rows.Add(dep.id, dep.address);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditDepartment addFrm=new AddEditDepartment();
            addFrm.FormClosing += new FormClosingEventHandler(Department_Load);
            addFrm.ShowDialog();
        }

        private void departmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepartmentBUS departmentBUS=new DepartmentBUS();
            int id= Convert.ToInt32(departmentTable.Rows[e.RowIndex].Cells["ID"].Value);
            string dep = departmentTable.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                AddEditDepartment editFrm = new AddEditDepartment(id,dep);
                editFrm.FormClosing += new FormClosingEventHandler(Department_Load);
                editFrm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                departmentBUS.xoaCoSo(id);
                loadData();
            }
            
        }
    }
}
