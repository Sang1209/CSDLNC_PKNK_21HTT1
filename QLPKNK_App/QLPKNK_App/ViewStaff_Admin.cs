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
    public partial class ViewStaff_Admin : Form
    {
        public ViewStaff_Admin()
        {
            InitializeComponent();
            AddUpdateButton();
            LoadStaffList();
            StaffRole.SelectedIndex = 0;
        }

        private void ViewStaff_Admin_Load(object sender, EventArgs e)
        {

        }

        private void AddUpdateButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Text = "Update";
            buttonColumn.UseColumnTextForButtonValue = true;
            StaffList.Columns.Add(buttonColumn);
            StaffList.CellContentClick += StaffList_CellContentClick;
        }
        private void LoadView(IList<Admin_StaffDTO> data)
        {
            StaffList.DataSource = data;
        }
        private void LoadStaffList()
        {

            Admin_StaffBUS nvBUS = new Admin_StaffBUS();
            IList<Admin_StaffDTO> nvList = nvBUS.layDSNhanVien();

            LoadView(nvList);
        }
        private void LoadRoleList(bool type)
        {

            Admin_StaffBUS nvBUS = new Admin_StaffBUS();
            IList<Admin_StaffDTO> nvList = nvBUS.locNhanVien_Loai(type);

            LoadView(nvList);
        }
        private void StaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được bấm có phải là cột chứa nút không
            if (e.ColumnIndex == StaffList.Columns[""].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = StaffList.Rows[e.RowIndex];
                string username = selectedRow.Cells["username"].Value.ToString();
                Console.WriteLine(username);

                UpdateAdmin_Staff openForm = new UpdateAdmin_Staff(username);
                openForm.ShowDialog();
            }
        }

        private void SearchStaff(string name)
        {
            Admin_StaffBUS nvBUS = new Admin_StaffBUS();
            IList<Admin_StaffDTO> nvList = nvBUS.locNhanVien_Ten(name);

            LoadView(nvList);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameSearch.Text))
            {
                LoadStaffList();
                StaffRole.SelectedIndex = 0;
            }
            else
            {
                string name = NameSearch.Text;
                SearchStaff(name);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAdmin_Staff a = new AddAdmin_Staff();
            a.Show();
        }

        private void StaffRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaffRole.SelectedIndex == 0) 
            {
                LoadStaffList();
            }
            else if (StaffRole.SelectedIndex == 1)
            {
                LoadRoleList(false);
            }
            else
            {
                LoadRoleList(true);
            }
        }
    }
}
