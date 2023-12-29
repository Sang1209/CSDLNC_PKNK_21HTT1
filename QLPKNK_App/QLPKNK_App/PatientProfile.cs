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
        public PatientProfile()
        {
            InitializeComponent();
            AddUpdateButton();
            LoadPatientList();
        }

        private void PatientProfile_Load(object sender, EventArgs e)
        {

        }

        private void AddUpdateButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "update";
            buttonColumn.Text = "Update";
            buttonColumn.UseColumnTextForButtonValue = true;
            PatientList.Columns.Add(buttonColumn);

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.Name = "treatment";
            buttonColumn2.Text = "Add";
            buttonColumn2.UseColumnTextForButtonValue = true;
            PatientList.Columns.Add(buttonColumn2);
        }
        private void LoadView(IList<HoSoDTO> data) 
        {
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
            if (e.ColumnIndex == PatientList.Columns["update"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PatientList.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                UpdatePatient openForm = new UpdatePatient(id);
                openForm.ShowDialog();
            }
            else if (e.ColumnIndex == PatientList.Columns["treatment"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PatientList.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                AddTreatment openForm = new AddTreatment(id);
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

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddProfile a = new AddProfile();
            a.Show();
        }
    }
}


