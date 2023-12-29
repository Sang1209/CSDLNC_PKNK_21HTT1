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
    public partial class reserveSchedule : Form
    {
        DateTime d;
        int sID;
        string den;
        public reserveSchedule()
        {
            InitializeComponent();
        }
        public reserveSchedule(DateTime d,int sID,string den)
        {
            InitializeComponent();
            this.d = d;
            this.sID = sID;
            this.den = den;
        }

        private void reserveSchedule_Load(object sender, EventArgs e)
        {
            date.Value= d;
            shiftID.Text = sID.ToString();
            dentist.Text = den;
            CaBUS caBUS = new CaBUS();
            CaDTO caDTO = caBUS.LayTTCa(sID);
            from.Text = caDTO.start.ToString();
            to.Text = caDTO.finish.ToString();
            patientCB.Items.Clear();
            patientCB.DisplayMember = "name";
            BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
            IList<BenhNhanDTO> dsbenhNhan = benhNhanBUS.layDSBenhNhan();
            patientCB.Items.AddRange(dsbenhNhan.ToArray());
            if(patientCB.Items.Count>0)
            {
                patientCB.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = date.Value;
            int sID=Convert.ToInt32( shiftID.Text);
            string den=dentist.Text;
            int pID = ((BenhNhanDTO)patientCB.SelectedItem).id;
            LichHenBUS lichHenBUS = new LichHenBUS();
            lichHenBUS.datLichHen(d, sID, den, pID);
            this.Close();
        }

        private void AddNewPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
