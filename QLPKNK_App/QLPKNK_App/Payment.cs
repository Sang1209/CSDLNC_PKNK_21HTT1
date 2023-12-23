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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void searchPatient_Click(object sender, EventArgs e)
        {
            int pID = ((BenhNhanDTO)patientSearch.SelectedItem).id;
            PaymentTable.Rows.Clear();
            HienThiHoaDonKH(pID);
        }
        private void HienThiHoaDonKH(int pID)
        {
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            IList<HoaDonDTO> dsHoaDon = hoaDonBUS.LayDSHoaDon(pID);
            foreach(HoaDonDTO d in dsHoaDon)
            {
                PaymentTable.Rows.Add(d.treatment,d.times,d.total,d.given,d.method,d.date.ToShortDateString(), d.payer, d.note);
            }

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            BenhNhanBUS bnBUS = new BenhNhanBUS();
            IList<BenhNhanDTO> DSBN = bnBUS.layDSBenhNhan();
            patientSearch.DisplayMember = "Name";
            patientSearch.Items.AddRange(DSBN.ToArray());
            patientSearch.KeyDown += new KeyEventHandler(keyDownEvt);
            if (patientSearch.Items.Count > 0)
            {
                patientSearch.SelectedIndex = 0;
            }
        }
        private void keyDownEvt(object sender, EventArgs e)
        {
            patientSearch.DroppedDown = false;
        }
    }
}
