using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class Medicine : Form
    {
        public object ThuocBus { get; private set; }

        public Medicine()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mId = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string mName = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            Double price = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["price"].Value);

            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {

                EditMedicine editFrm = new EditMedicine(mId, mName, price);
                editFrm.FormClosing += new FormClosingEventHandler(this.EditMedicine_FormClosing);
                editFrm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                ThuocBUS ThuocBUS = new ThuocBUS();
                ThuocBUS.XoaThuoc(mId);
                LoadData();
            }
        }

        private void EditMedicine_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            ThuocBUS tBUS = new ThuocBUS();
            IList<ThuocDTO> dsThuoc = tBUS.LayDSThuoc();
            foreach (ThuocDTO dt in dsThuoc)
            {
                dataGridView1.Rows.Add(dt.id, dt.name, dt.price);
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMedicine addFrm = new AddMedicine();
            addFrm.FormClosing += new FormClosingEventHandler(this.EditMedicine_FormClosing);
            addFrm.ShowDialog();
        }
    }
}
