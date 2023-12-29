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
    public partial class ViewMedUsage : Form
    {
        public ViewMedUsage()
        {
            InitializeComponent();
        }

        private void ViewMedUsage_Load(object sender, EventArgs e)
        {
            MedUseBUS medUseBUS = new MedUseBUS();
            medUsedDay.Rows.Clear();
            medUsedMonth.Rows.Clear();
            IList<MedUseDTO> medUseToday= medUseBUS.getMedUseToday();
            IList<MedUseDTO> medUseM = medUseBUS.getMedUseMonth();
            foreach (MedUseDTO m in medUseToday)
            {
                medUsedDay.Rows.Add(m.medID,m.medName,m.usage);
            }
            foreach (MedUseDTO m in medUseM)
            {
                medUsedMonth.Rows.Add(m.medID, m.medName, m.usage);
            }
        }
    }
}
