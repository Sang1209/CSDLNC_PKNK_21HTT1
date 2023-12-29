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
    public partial class UpdateContradicated : Form
    {
        public int pId { get; set; }
        public string mid { get; set; }
        public string mName { get; set; }
        public UpdateContradicated(int pId, string mid, string mName)
        {
            InitializeComponent();
            hienThiDSThuoc();
            this.pId = pId;
            this.mid = mid;
            textBox1.Text = pId.ToString();
            textBox2.Text = mName;
        }

        private void hienThiDSThuoc()
        {
            MedicineCB.DisplayMember = "name";
            MedicineCB.ValueMember = "id";
            ThuocBUS thuocBUS = new ThuocBUS();
            IList<ThuocDTO> dsThuoc = thuocBUS.LayDSThuoc();
            MedicineCB.Items.AddRange(dsThuoc.ToArray<ThuocDTO>());
            MedicineCB.KeyDown += new KeyEventHandler(MedCBkeyDown);
            if (MedicineCB.Items.Count > 0)
            {
                MedicineCB.SelectedIndex = 0;
            }
        }
        private void MedCBkeyDown(object sender, EventArgs e)
        {
            MedicineCB.DroppedDown = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiUngBUS DiUngBUS = new DiUngBUS();
            string midnew = MedicineCB.Text;
            DiUngBUS.capNhatDiUng(pId, mid, midnew);
            this.Close();
        }
    }

}
    

