using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class AddContradicated : Form
    {
        
        public AddContradicated()
        {
            
            InitializeComponent();
            hienThiDSThuoc();
            hienThiDSBenhNhan();
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
        private void hienThiDSBenhNhan()
        {
            PatientCB.DisplayMember = "name";
            PatientCB.ValueMember = "id";
            BenhNhanBUS BenhNhanBUS = new BenhNhanBUS();
            IList<BenhNhanDTO> dsBenhNhan = BenhNhanBUS.layDSBenhNhan();
            PatientCB.Items.Add(new BenhNhanDTO() { id = -1, name = "All" });
            PatientCB.Items.AddRange(dsBenhNhan.ToArray());
            MedicineCB.KeyDown += new KeyEventHandler(MedCBkeyDown2);
            if (PatientCB.Items.Count > 0)
            {
                PatientCB.SelectedIndex = 0;
            }
        }
        private void MedCBkeyDown2(object sender, EventArgs e)
        {
            PatientCB.DroppedDown = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiUngBUS DiUngBUS = new DiUngBUS();
            int patient = ((BenhNhanDTO)PatientCB.SelectedItem).id;
            string medicine = ((ThuocDTO)MedicineCB.SelectedItem).id;
            DiUngBUS.themDiUng(patient,medicine);
            Close();
        }

        private void MedicineCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    }
}
