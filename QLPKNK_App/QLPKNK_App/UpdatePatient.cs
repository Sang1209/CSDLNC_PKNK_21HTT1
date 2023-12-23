using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPKNK_App.BUS;
using QLPKNK_App.DTO;

namespace QLPKNK_App
{
    public partial class UpdatePatient : Form
    {
        public UpdatePatient()
        {
            InitializeComponent();
        }

        public UpdatePatient(int pID)
        {
            InitializeComponent();
            HoSoBUS hsBus = new HoSoBUS();
            HoSoDTO hs = hsBus.layThongTinHoSO(pID);
            ProfileID.Text = hs.id.ToString();
            PatientName.Text = hs.name;
            textBox1.Text = hs.birth.ToString();
            PatientPhone.Text = hs.phone;
            PatientEmail.Text = hs.email;
            PatientAddress.Text = hs.address;
            if (hs.gender == true)
                PatientGender.SelectedIndex = 0;
            else
                PatientGender.SelectedIndex = 1;

        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {

        }

        private void ProfileID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
