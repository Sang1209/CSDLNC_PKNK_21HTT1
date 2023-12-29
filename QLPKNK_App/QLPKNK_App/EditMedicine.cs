using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
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
    public partial class EditMedicine : Form
    {

        public EditMedicine(string id, string newName, float newPrice)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = Id.Text;
            string newName = NewName.Text;
            float newPrice;

            if (float.TryParse(NewPrice.Text, out newPrice))
            {
                
                ThuocBUS thuocBUS = new ThuocBUS();
                thuocBUS.SuaThuoc(id, newName, newPrice);

                
                Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá thuốc là một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
