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
    public partial class ViewPatientProfile : Form
    {
        public ViewPatientProfile()
        {
            InitializeComponent();
            LoadPatientList();
        }


        private void LoadPatientList()
        {

            BenhNhanBUS bnBUS = new BenhNhanBUS();
            IList<HoSoDTO> bnList = bnBUS.LayDsHoSo();

            PatientList.DataSource = bnList;
        }

        private void PatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
