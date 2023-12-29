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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            PatientBirth.Value = hs.birth;
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

        private void PatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PatientPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientName.Text) || string.IsNullOrWhiteSpace(PatientPhone.Text) || string.IsNullOrWhiteSpace(PatientAddress.Text))
            {
                MessageBox.Show("Please input all necessary information");
                return;
            }
            int id = (int)ProfileID.Value;
            string name = PatientName.Text;
            string phone = PatientPhone.Text;
            DateTime birth = PatientBirth.Value;
            string email = PatientEmail.Text;
            string address = PatientAddress.Text;
            bool gender = (PatientGender.SelectedIndex == 0 ? true : false);

            HoSoBUS hsBUS = new HoSoBUS();
            hsBUS.capNhatHoSo(id, name, birth, phone, email, address, gender);
        }
    }
}
