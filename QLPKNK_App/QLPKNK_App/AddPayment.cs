using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
            hienThiDSCachTra();
            hienThiDSDonThuoc();
        }

        private void hienThiDSDonThuoc()
        {
            TreatmentCB.DisplayMember = "id";
            KHDieuTriBUS KHDieuTriBUS = new KHDieuTriBUS();
            IList<KHDieuTriDTO> dsDieuTri = KHDieuTriBUS.layDSDieuTri();
            TreatmentCB.Items.AddRange(dsDieuTri.ToArray<KHDieuTriDTO>());
            TreatmentCB.KeyDown += new KeyEventHandler(MedCBkeyDown);
            if (TreatmentCB.Items.Count > 0)
            {
                TreatmentCB.SelectedIndex = 0;
            }
        }
        private void MedCBkeyDown(object sender, EventArgs e)
        {
            TreatmentCB.DroppedDown = false;
        }

        private void hienThiDSCachTra()
        {
            MethodCB.DisplayMember = "name";
            CachTraBUS CachTraBUS = new CachTraBUS();
            IList<CachTraDTO> dsCachTra = CachTraBUS.layDSCachTra();
            MethodCB.Items.AddRange(dsCachTra.ToArray<CachTraDTO>());
            MethodCB.KeyDown += new KeyEventHandler(MedCBkeyDown2);
            if (MethodCB.Items.Count > 0)
            {
                MethodCB.SelectedIndex = 0;
            }
        }
        private void MedCBkeyDown2(object sender, EventArgs e)
        {
            MethodCB.DroppedDown = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            HoaDonBUS HoaDonBUS = new HoaDonBUS();
            DateTime d = datePayment.Value;
            double money = Convert.ToDouble(moneyPayment.Value);
            double change = Convert.ToDouble(changePayment.Value);
            int treatment = ((KHDieuTriDTO)TreatmentCB.SelectedItem).id;
            int method = ((CachTraDTO)MethodCB.SelectedItem).id;
            string note = notePayment.Text;
            string payer = Payer.Text;
            HoaDonBUS.taoHoaDon(d, treatment, method, money, change, payer, note);
            Close();
        }

        private void TreatmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
