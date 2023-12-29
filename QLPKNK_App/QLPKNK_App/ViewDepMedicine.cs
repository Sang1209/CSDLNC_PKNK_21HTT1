using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class ViewDepMedicine : Form
    {
        int id;
        string addr;
        public ViewDepMedicine()
        {
            InitializeComponent();
        }
        public ViewDepMedicine(int id,string dep)
        {
            InitializeComponent();
            depAddr.Text = dep;
            this.id = id;
            this.addr = dep;
        }

        private void ViewDepMedicine_Load(object sender, EventArgs e)
        {
            loadData();
            depMedTable.CellValueChanged += new DataGridViewCellEventHandler(updateMedDep);
        }
        private void loadData()
        {
            depMedTable.Rows.Clear();
            DepartmentBUS departmentBUS = new DepartmentBUS();
            IList<MedDepDTO> ds = departmentBUS.layDSThuoc_CoSo(id);
            foreach (MedDepDTO d in ds)
            {
                depMedTable.Rows.Add(d.mID, d.name, d.remain);
            }
            depMedTable.CellValidating += new DataGridViewCellValidatingEventHandler(checkNum);

        }
        private void checkNum(object sender, DataGridViewCellValidatingEventArgs e)
        {
            depMedTable.Rows[e.RowIndex].ErrorText = "";
            int newInteger;
            if (depMedTable.Rows[e.RowIndex].IsNewRow) { return; }
            if (!int.TryParse(e.FormattedValue.ToString(),
                out newInteger) || newInteger < 0)
            {
                e.Cancel = true;
                depMedTable.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            }
        }
        private void updateMedDep(object sender, DataGridViewCellEventArgs e)
        {
            DepartmentBUS departmentBUS=new DepartmentBUS();
            string mID = depMedTable.Rows[e.RowIndex].Cells["MedId"].Value.ToString();
            int quantity = Convert.ToInt32(depMedTable.Rows[e.RowIndex].Cells["remain"].Value);
            departmentBUS.capNhatThuoc_CoSo(mID,id,quantity);
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMedDep addMedDep= new AddMedDep(id,addr);
            addMedDep.FormClosing += new FormClosingEventHandler(ViewDepMedicine_Load);
            addMedDep.ShowDialog();
        }
    }
}
