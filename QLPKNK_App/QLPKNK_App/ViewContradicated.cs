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
    public partial class ViewContradicated : Form
    {
        public ViewContradicated()
        {
            InitializeComponent();
        }

        private void ViewContradicated_Load(object sender, EventArgs e)
        {
            refreshData();
            patient.DisplayMember = "pName";
            patient.SelectedIndexChanged += new EventHandler(loadData);
        }
        private void refreshData()
        {
            contraTable.Rows.Clear();
            DiUngBUS diUngBUS = new DiUngBUS();
            IList<DiUngDTO> dsDiUng = diUngBUS.layDSDiUng();
            foreach (DiUngDTO d in dsDiUng)
            {
                contraTable.Rows.Add(d.patient, d.pName, d.medicine, d.medName);
            }
        }
        private void loadData(object sender, EventArgs e)
        {
            contraTable.Rows.Clear();
            int pId = ((DiUngDTO)patient.SelectedItem).patient;
            DiUngBUS diUngBUS = new DiUngBUS();
            IList<DiUngDTO> dsDiUng = diUngBUS.layDSDiUngTheoBN(pId);
            foreach (DiUngDTO d in dsDiUng)
            {
                contraTable.Rows.Add(d.patient, d.pName, d.medicine, d.medName);
            }
        }

      /*  private void contraTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiUngBUS diUngBUS = new DiUngBUS();
            int pId = Convert.ToInt32(contraTable.Rows[e.RowIndex].Cells["PatientID"].Value);
            int mId = Convert.ToInt32(contraTable.Rows[e.RowIndex].Cells["MedicineID"].Value);
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                UpdateContradicated u=new UpdateContradicated(pId, mId);
                u.FormClosing += new FormClosingEventHandler(ViewContradicated_Load);
                u.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                diUngBUS.xoaDiUng(pId, mId);
                refreshData();
            }
        }*/
    }
}
