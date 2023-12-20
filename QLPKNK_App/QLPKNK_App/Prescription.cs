using buhbuhlmao;
using buhbuhlmao.BUS;
using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class Prescription : Form
    {
        public int tId { get; set; }
        public Prescription()
        {
            InitializeComponent();
            
        }
        public Prescription(string strTextBox)
        {
            InitializeComponent();
            tId = Convert.ToInt32(strTextBox);
            label1.Text = "Prescription of treatment id " + strTextBox;
        }
        private void Prescription_Load(object sender, EventArgs e)
        {
            label1.Text = "Prescription of treatment id " + tId;
            hienThiDonThuocCuaKHDT();
            hienThiDSThuoc();
        }
        private void hienThiDonThuocCuaKHDT()
        {
            PrescriptionTable.Rows.Clear();
            DonThuocBUS dtBus=new DonThuocBUS();
            IList<DonThuocDTO> dsThuoc = dtBus.layDsThuocCuaKHDT(tId);
            foreach (DonThuocDTO dt in dsThuoc)
            {
                PrescriptionTable.Rows.Add( dt.medicineId, dt.medicineName, dt.quantity, dt.note);
            }

        }
        private void hienThiDSThuoc()
        {
            MedicineNameCB.DisplayMember= "name";
            MedicineNameCB.ValueMember = "id";
            ThuocBUS thuocBUS = new ThuocBUS();
            IList<ThuocDTO> dsThuoc = thuocBUS.LayDSThuoc();
            MedicineNameCB.Items.AddRange(dsThuoc.ToArray<ThuocDTO>());
            if(MedicineNameCB.Items.Count > 0)
            {
                MedicineNameCB.SelectedIndex = 0;
            }
        }
        private void addMedicine_Click(object sender, EventArgs e)
        {
            DonThuocBUS donThuocBUS = new DonThuocBUS();
            if((int)MedicineQuantity.Value==0)
            {
                MessageBox.Show(this, "Please provide the amount of medicine you want to add!");
            }
            string mId = ((ThuocDTO)MedicineNameCB.SelectedItem).id;
            int quantity = (int)MedicineQuantity.Value;
            if (String.IsNullOrEmpty(MedicineNote.Text))
            {
                var confirmResult = MessageBox.Show("You have not enter any note. Do you want to continue adding this medicine?","Empty note", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    donThuocBUS.themThuocChoKHDT(tId,mId,quantity,null);
                    hienThiDonThuocCuaKHDT();
                }
            }
            else
            {
                string note = MedicineNote.Text;
                donThuocBUS.themThuocChoKHDT(tId, mId, quantity, note);
                hienThiDonThuocCuaKHDT();
            }
            
        }
    }
}
