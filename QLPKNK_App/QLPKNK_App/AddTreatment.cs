using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPKNK_App.BUS;
using QLPKNK_App.DTO;

namespace QLPKNK_App
{
    public partial class AddTreatment : Form
    {
        public AddTreatment()
        {
            InitializeComponent();
        }
        public AddTreatment(int pID)
        {
            InitializeComponent();
            LoadData(pID);
        }
        private void LoadData(int pID)
        {
            PatientID.Value = pID;

            HoSoDTO hs = new HoSoDTO();
            HoSoBUS hsBUS = new HoSoBUS();
            hs = hsBUS.layThongTinHoSO(pID);
            PatientName.Text = hs.name;
        }
    }
}
