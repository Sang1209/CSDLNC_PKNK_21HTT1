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
    public partial class AddMedDep : Form
    {
        int depID;
        public AddMedDep()
        {
            InitializeComponent();
        }
        public AddMedDep(int depID,string depAddr)
        {
            InitializeComponent();
            DepAddr.Text = depAddr;
            this.depID = depID;
        }

        private void AddMedDep_Load(object sender, EventArgs e)
        {
            MedCB.Items.Clear();
            DepartmentBUS departmentBUS = new DepartmentBUS();
            IList<ThuocDTO> dsThuoc = departmentBUS.dsThuocChuaThem_CoSo(depID);
            MedCB.DisplayMember = "name";
            MedCB.Items.AddRange(dsThuoc.ToArray());
            if(MedCB.Items.Count > 0 )
            {
                MedCB.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mID = ((ThuocDTO)MedCB.SelectedItem).id;
            int quantity=Convert.ToInt32(medAmount.Value);
            DepartmentBUS departmentBUS=new DepartmentBUS();
            departmentBUS.taoThuoc_CoSo(mID, depID, quantity);
            this.Close();
        }
    }
}
