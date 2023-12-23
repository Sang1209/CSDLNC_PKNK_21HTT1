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
    public partial class AddEditPrescription : Form
    {
        public int tId { get; set; }
        public string mid { get; set; }
        public AddEditPrescription()
        {
            InitializeComponent();
        }
        public AddEditPrescription(int tId)
        {
            InitializeComponent();
            this.tId = tId;
            hienThiDSThuoc();
            Title.Text = "Add medicine for prescription " + tId;
            updatedMedName.Hide();
        }
        public AddEditPrescription(int tId,string mid, string mName,int quantity,string note)
        {
            InitializeComponent();
            this.tId = tId;
            this.mid = mid;
            hienThiDSThuoc();
            Title.Text = "Update medicine "+mid+":"+mName +" for prescription " + tId;
            MedicineQuantity.Value = quantity;
            MedicineNote.Text = note;
            updatedMedName.Text= mName;
            MedicineNameCB.Hide();
        }
        private void addMedicine(object sender, EventArgs e)
        {
            DonThuocBUS donThuocBUS = new DonThuocBUS();
            if ((int)MedicineQuantity.Value == 0)
            {
                MessageBox.Show(this, "Please provide the amount of medicine you want to add!");
            }
            string mId = ((ThuocDTO)MedicineNameCB.SelectedItem).id;
            int quantity = (int)MedicineQuantity.Value;
            if (String.IsNullOrEmpty(MedicineNote.Text))
            {
                var confirmResult = MessageBox.Show("You have not enter any note. Do you want to continue adding this medicine?", "Empty note", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    donThuocBUS.themThuocChoKHDT(tId, mId, quantity, null);
                    this.Close();
                }
            }
            else
            {
                string note = MedicineNote.Text;
                donThuocBUS.themThuocChoKHDT(tId, mId, quantity, note);
                this.Close();
            }
            
        }
        private void updateMedicine(object sender, EventArgs e)
        {
            DonThuocBUS donThuocBUS = new DonThuocBUS();
            if ((int)MedicineQuantity.Value == 0)
            {
                MessageBox.Show(this, "Please provide the amount of medicine you want to add!");
            }
            int quantity = (int)MedicineQuantity.Value;
            if (String.IsNullOrEmpty(MedicineNote.Text))
            {
                var confirmResult = MessageBox.Show("You have not enter any note. Do you want to continue adding this medicine?", "Empty note", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    donThuocBUS.suaThuocChoKHDT(tId, mid, quantity, null);
                    this.Close();
                }
            }
            else
            {
                string note = MedicineNote.Text;
                donThuocBUS.suaThuocChoKHDT(tId, mid, quantity, note);
                this.Close();
            }
            
        }
        private void hienThiDSThuoc()
        {
            MedicineNameCB.DisplayMember = "name";
            MedicineNameCB.ValueMember = "id";
            ThuocBUS thuocBUS = new ThuocBUS();
            IList<ThuocDTO> dsThuoc = thuocBUS.LayDSThuoc();
            MedicineNameCB.Items.AddRange(dsThuoc.ToArray<ThuocDTO>());
            MedicineNameCB.KeyDown += new KeyEventHandler(MedCBkeyDown);
            if (MedicineNameCB.Items.Count > 0)
            {
                MedicineNameCB.SelectedIndex = 0;
            }
        }
        private void MedCBkeyDown(object sender, EventArgs e)
        {
            MedicineNameCB.DroppedDown = false;
        }
        private void AddEditPrescription_Load(object sender, EventArgs e)
        {
            Button b=new Button();
            b.Left = 172;
            b.Top = 363;
            if (!String.IsNullOrEmpty(mid))
            {
                b.Text = "Update";
                b.Click += new EventHandler(updateMedicine);
                
            }
            else
            {
                b.Text = "Add";
                b.Click += new EventHandler(addMedicine);
            }
            Controls.Add(b);
        }

        private void updatedMedName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
