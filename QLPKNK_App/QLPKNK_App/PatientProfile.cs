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
    public partial class PatientProfile : Form
    {
        List<HoSoDTO> rowsChanged = new List<HoSoDTO>();
        public PatientProfile()
        {
            InitializeComponent();
            LoadPatientList();
        }

        private void PatientProfile_Load(object sender, EventArgs e)
        {

        }

        private void LoadPatientList()
        {

            HoSoBUS hsBUS = new HoSoBUS();
            IList<HoSoDTO> hsList = hsBUS.LayDsHoSo();

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Text = "Update";
            buttonColumn.UseColumnTextForButtonValue = true;
            PatientList.Columns.Add(buttonColumn);
            PatientList.CellContentClick += PatientList_CellContentClick;

            PatientList.DataSource = hsList;

            foreach (DataGridViewColumn column in PatientList.Columns)
            {
                if (column.Name == "id")
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void PatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được bấm có phải là cột chứa nút không
            if (e.ColumnIndex == PatientList.Columns[""].Index && e.RowIndex >= 0)
            {
                int id = (int)PatientList.Rows[e.RowIndex].Cells[0].Value;
                UpdatePatient openForm = new UpdatePatient(id);
                openForm.Show();
            }
        }
    }
}


