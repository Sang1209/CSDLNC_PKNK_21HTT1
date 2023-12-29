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
    public partial class ViewDentist : Form
    {
        public ViewDentist()
        {
            InitializeComponent();
            LoadDepartment();
            AddUpdateButton();
            LoadDentistList();
        }
        private void joinList(IList<NhaSiDTO> data)
        {
            DepartmentBUS depBUS = new DepartmentBUS();
            IList<DepartmentDTO> dsDep = depBUS.LayDSDepartment();

            var joinedList = from a in data
                             join b in dsDep on a.depID equals b.id
                             select new
                             {
                                 a.username,
                                 a.password,
                                 a.name,
                                 a.phone,
                                 a.email,
                                 a.address,
                                 a.gender,
                                 a.depID,
                                 dep_addr = b.address,
                             };
            
        }
        private void LoadDepartment()
        {
            DepartmentBUS depBUS = new DepartmentBUS();
            IList<DepartmentDTO> dsDep= depBUS.LayDSDepartment();

            DepartmentDTO all = new DepartmentDTO();
            all.id = 0;
            all.address = "All";

            dsDep.Insert(0, all);
            DentistDepartment.DataSource = dsDep;
            DentistDepartment.DisplayMember = "address";
            DentistDepartment.ValueMember = "id";
        }
        private void AddUpdateButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Text = "Update";
            buttonColumn.UseColumnTextForButtonValue = true;
            DentistList.Columns.Add(buttonColumn);
            DentistList.CellContentClick += DentistList_CellContentClick;
        }
        private void LoadView(IList<NhaSiDTO> data)
        {
            DentistList.DataSource = data;
        }
        private void LoadDentistList()
        {

            NhaSiBUS nsBUS = new NhaSiBUS();
            IList<NhaSiDTO> nsList = nsBUS.layDSNhaSi();

            LoadView(nsList);
        }
        private void DentistList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được bấm có phải là cột chứa nút không
            if (e.ColumnIndex == DentistList.Columns[""].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DentistList.Rows[e.RowIndex];
                string username = selectedRow.Cells["username"].Value.ToString();
                Console.WriteLine(username);

                UpdateDentist openForm = new UpdateDentist(username);
                openForm.ShowDialog();
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDentist a = new AddDentist();
            a.Show();
        }

        private void DentistDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DentistDepartment.SelectedValue.ToString() != "All")
            {
                int depID = (int)DentistDepartment.SelectedValue;
                if (depID == 0)
                {
                    LoadDentistList();
                }
                else
                {
                    NhaSiBUS nsBUS = new NhaSiBUS();
                    IList<NhaSiDTO> nsList = nsBUS.locNhaSi_Department(depID);

                    LoadView(nsList);
                }
            }
        }
        private void SearchDentist(string name)
        {
            NhaSiBUS nsBUS = new NhaSiBUS();
            IList<NhaSiDTO> nsList = nsBUS.locNhaSi_Ten(name);

            LoadView(nsList);
        }
        private void ViewDentist_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameSearch.Text))
            {
                LoadDentistList();
                DentistDepartment.SelectedIndex = 0;
            }
            else
            {
                string name = NameSearch.Text;
                SearchDentist(name);
            }
        }
    }
}
