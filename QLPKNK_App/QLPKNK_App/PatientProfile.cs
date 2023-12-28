using System;
using System.Collections;
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

        private void LoadView(IList<HoSoDTO> data) 
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Text = "Update";
            buttonColumn.UseColumnTextForButtonValue = true;
            PatientList.Columns.Add(buttonColumn);

            PatientList.DataSource = data;
        }
        private void LoadPatientList()
        {

            HoSoBUS hsBUS = new HoSoBUS();
            IList<HoSoDTO> hsList = hsBUS.LayDsHoSo();

            LoadView(hsList);
        }

        private void SearchPatient(string name)
        {

            HoSoBUS hsBUS = new HoSoBUS();
            IList<HoSoDTO> hsSearchList = hsBUS.TimHoSo(name);

            LoadView(hsSearchList);
        }

        private void PatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được bấm có phải là cột chứa nút không
            if (e.ColumnIndex == PatientList.Columns[""].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PatientList.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                UpdatePatient openForm = new UpdatePatient(id);
                openForm.ShowDialog();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchName.Text))
            {
                LoadPatientList();
            }
            else
            {
                string name = SearchName.Text;
                SearchPatient(name);
            }
        }
    }
}


