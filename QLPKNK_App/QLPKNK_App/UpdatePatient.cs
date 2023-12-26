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
        public int id;
        public string oldName;
        public string newName;
        public string birth = null;
        public DateTime oldBirth;
        public DateTime newBirth;
        public string oldPhone;
        public string newPhone;
        public string oldEmail;
        public string newEmail;
        public string oldAddress;
        public string newAddress;
        public string gender = null;
        public bool oldGender;
        public bool newGender;
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
            id = hs.id;

            PatientName.Text = hs.name;
            oldName = hs.name;
            PatientBirth.Value = hs.birth;
            oldBirth = hs.birth;
            PatientPhone.Text = hs.phone;
            oldPhone = hs.phone;
            PatientEmail.Text = hs.email;
            oldEmail = hs.email;
            PatientAddress.Text = hs.address;
            oldAddress = hs.address;
            if (hs.gender == true)
                PatientGender.SelectedIndex = 0;
            else
                PatientGender.SelectedIndex = 1;
            oldGender = hs.gender;
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {
           
        }

        private void ProfileID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PatientName_TextChanged(object sender, EventArgs e)
        {
            newName = PatientName.Text;
        }

        private void PatientBirth_ValueChanged(object sender, EventArgs e)
        {
            newBirth = PatientBirth.Value;
        }

        private void PatientPhone_TextChanged(object sender, EventArgs e)
        {
           newPhone = PatientPhone.Text;
        }

        private void PatientEmail_TextChanged(object sender, EventArgs e)
        {
            newEmail = PatientEmail.Text;
        }

        private void PatientAddress_TextChanged(object sender, EventArgs e)
        {
            newAddress = PatientAddress.Text;
        }

        private void PatientGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatientGender.SelectedIndex == 0)
                newGender = true;
            else newGender = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (oldName == newName)
                newName = null;
            if (oldBirth != newBirth)
                birth = newBirth.ToString("MM/dd/yyyy");
            if (oldPhone == newPhone)
                newPhone = null;
            if (oldEmail == newEmail)
                newEmail = null;
            if (oldAddress == newAddress)
                newAddress = null;
            if (oldGender != newGender)
                gender = "gender^1";
            HoSoBUS hsBUS = new HoSoBUS();
            hsBUS.capNhatHoSo(id, newName, birth, newPhone, newEmail, newAddress, gender);
        }
    }
}
