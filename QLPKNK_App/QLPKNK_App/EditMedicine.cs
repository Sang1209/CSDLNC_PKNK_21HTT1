using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App
{
    public partial class EditMedicine : Form
    {
        public string id { get; set; }
        public EditMedicine(string id, string name, double price)
        {
            InitializeComponent();
            this.id = id;
            on.Text = name;
            op.Text = price.ToString();
            textBox1.Text = id;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            ThuocBUS ThuocBUS = new ThuocBUS();
            string nname = textBox2.Text;
            Double nprice = Convert.ToDouble(textBox3.Text);
            ThuocBUS.SuaThuoc(id, nname, nprice);
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
