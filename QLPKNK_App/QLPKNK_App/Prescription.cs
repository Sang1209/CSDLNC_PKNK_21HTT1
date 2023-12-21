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
        
        private void addMedicine_Click(object sender, EventArgs e)
        {
            AddEditPrescription addFrm=new AddEditPrescription(tId);
            addFrm.FormClosing+=new FormClosingEventHandler(this.AddEditPrescription_FormClosing);
            addFrm.ShowDialog();
        }
        private void AddEditPrescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            hienThiDonThuocCuaKHDT();
        }

        private void PrescriptionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mId = PrescriptionTable.Rows[e.RowIndex].Cells["MedID"].Value.ToString();
            string mName = PrescriptionTable.Rows[e.RowIndex].Cells["MedName"].Value.ToString();
            int quantity = Convert.ToInt32(PrescriptionTable.Rows[e.RowIndex].Cells["Quantity"].Value);
            string note = PrescriptionTable.Rows[e.RowIndex].Cells["Note"].Value.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
               
                AddEditPrescription editFrm=new AddEditPrescription(tId,mId, mName, quantity, note);
                editFrm.FormClosing+= new FormClosingEventHandler(this.AddEditPrescription_FormClosing);
                editFrm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DonThuocBUS donThuocBUS = new DonThuocBUS();
                donThuocBUS.xoaThuocChoKHDT(tId, mId);
                hienThiDonThuocCuaKHDT();
            }
        }
    }
}
