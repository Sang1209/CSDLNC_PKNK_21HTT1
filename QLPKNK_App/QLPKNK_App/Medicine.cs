using QLPKNK_App.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, name;
            float price;

         
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                price = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value);
            }
            else
            {
                return;
            }

            ThuocBUS thuocBUS = new ThuocBUS();

            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
   
                thuocBUS.XoaThuoc(id);
                LoadData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
   
                EditMedicine edit = new EditMedicine(id, name, price);
                edit.FormClosing += new FormClosingEventHandler((s, args) => LoadData());
                edit.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {

                AddMedicine add = new AddMedicine();
                add.FormClosing += new FormClosingEventHandler((s, args) => LoadData());
                add.ShowDialog();
            }
        }

        private void LoadData()
        {
            ThuocBUS thuocBUS = new ThuocBUS();
            dataGridView1.DataSource = thuocBUS.LayDSThuoc();
        }

    }
}
