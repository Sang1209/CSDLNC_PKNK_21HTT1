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

namespace QLPKNK_App
{
    public partial class AddProfile : Form
    {
        public AddProfile()
        {
            InitializeComponent();
        }

        private void AddProfile_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string name = PatientName.Text;
            DateTime birth = PatientBirth.Value;
            string phone = PatientPhone.Text;
            string email = PatientEmail.Text;
            string address = PatientAddress.Text;
            bool gender = (PatientGender.SelectedIndex == 0 ? true : false);

            HoSoBUS hsBUS = new HoSoBUS();
            hsBUS.themHoSo(name, birth, phone, email, address, gender);
        }
    }
}
