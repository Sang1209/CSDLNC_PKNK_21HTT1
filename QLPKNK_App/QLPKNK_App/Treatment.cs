using buhbuhlmao.BUS;
using QLPKNK_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buhbuhlmao
{
    public partial class Treatment : Form
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;

        public Treatment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //int tId = Convert.ToInt32(TreatmentTable.Rows[e.RowIndex].Cells["ID"].Value);
                string str = TreatmentTable.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                using (Prescription p = new Prescription(str))
                {
                    p.ShowDialog();
                }
            }
        }

        private void searchPatient_Click(object sender, EventArgs e)
        {
            int pID = (int)patientIDSearch.Value;
            TreatmentTable.Rows.Clear();
            HienThiKHDT(pID);
        }
        private void HienThiKHDT(int  pID)
        {
            KHDieuTriBUS kHDieuTriBUS = new KHDieuTriBUS();
            IList<KHDieuTriDTO> dsKHDT = kHDieuTriBUS.layDsKHDieuTriTheoBN(pID);
            foreach(KHDieuTriDTO khdt in dsKHDT)
            {
                TreatmentTable.Rows.Add("",khdt.id, khdt.department, khdt.patient, khdt.dentist, khdt.assistant, khdt.description, khdt.date, khdt.note, khdt.method, khdt.tooth_name, khdt.state, khdt.total);
            }
        }
    }
}
