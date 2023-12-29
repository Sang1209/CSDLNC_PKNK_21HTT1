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
    public partial class ViewContradicated : Form
    {
        private void keyDownEvt(object sender, EventArgs e)
        {
            PatientCB.DroppedDown = false;
        }
        private void Contradicated_Load(object sender, EventArgs e)
        {
            PatientCB.DisplayMember = "name";
            BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
            IList<BenhNhanDTO> dsBN = benhNhanBUS.layDSBenhNhan();
            PatientCB.Items.Add(new BenhNhanDTO() { id = -1, name = "All" });
            PatientCB.Items.AddRange(dsBN.ToArray());
            if (PatientCB.Items.Count > 0)
            {
                PatientCB.SelectedIndex = 0;
            }

            PatientCB.SelectedIndexChanged += new EventHandler(RefreshData);

            LoadData();
        }

        public ViewContradicated()
        {
            InitializeComponent();
        }
        private void RefreshData(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            contraTable.Rows.Clear();
            int pId = string.IsNullOrEmpty(PatientCB.Text) ? -1 : ((BenhNhanDTO)PatientCB.SelectedItem).id;
            DiUngBUS diUngBUS = new DiUngBUS();
            IList<DiUngDTO> dsDiUng = diUngBUS.layDSDiUngTheoBN(pId);
            foreach (DiUngDTO d in dsDiUng)
            {
                contraTable.Rows.Add(d.patient, d.pName, d.medicine, d.medName);
            }
        }
        


        private void PatientCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddContradicated addContradicated = new AddContradicated();
            addContradicated.FormClosing += new FormClosingEventHandler(Contradicated_Load);
            addContradicated.ShowDialog();
        }

        private void contraTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pId = Convert.ToInt32(contraTable.Rows[e.RowIndex].Cells["PatientID"].Value);
            string mId = contraTable.Rows[e.RowIndex].Cells["MedicineId"].Value.ToString();
            string mName = contraTable.Rows[e.RowIndex].Cells["MedicineName"].Value.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {

                UpdateContradicated editFrm = new UpdateContradicated(pId, mId, mName);
                editFrm.FormClosing += new FormClosingEventHandler(this.AddContradicated_FormClosing);
                editFrm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DiUngBUS DiUngBUS = new DiUngBUS();
                DiUngBUS.xoaDiUng(pId, mId);
                LoadData();
            }
        }

        private void AddContradicated_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadData();
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
