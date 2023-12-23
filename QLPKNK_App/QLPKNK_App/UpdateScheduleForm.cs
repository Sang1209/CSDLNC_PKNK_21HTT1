using QLPKNK_App.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLPKNK_App
{
    public partial class UpdateScheduleForm : Form
    {
        public UpdateScheduleForm()
        {
            InitializeComponent();
        }
        public UpdateScheduleForm(DateTime date,int shiftId,string dentist)
        {
            InitializeComponent();
            dentistName.Text = dentist;
            oldDate.Text=date.ToShortDateString();
            oldShiftID.Text = shiftId.ToString();
            CaBUS caBUS = new CaBUS();
            CaDTO oldShift = caBUS.LayTTCa(shiftId);
            oldFromTime.Text = oldShift.start.ToString();
            oldToTime.Text=oldShift.finish.ToString();
            newShiftID.ValueChanged += new EventHandler(capNhatTG);
        }
        private void capNhatTG(object sender, EventArgs e)
        {
            int shift = Convert.ToInt32(newShiftID.Value);
            CaBUS caBUS = new CaBUS();
            CaDTO ca = caBUS.LayTTCa(shift);
            newFromTime.Text = ca.start.ToString();
            newToTime.Text = ca.finish.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LichHenBUS lichHenBUS = new LichHenBUS();
            DateTime d_new = newDate.Value;
            int s_new = Convert.ToInt32(newShiftID.Value);
            DateTime d_old = DateTime.Parse(oldDate.Text);
            int s_old= Convert.ToInt32(oldShiftID.Text);
            string dentist = dentistName.Text;
            lichHenBUS.capNhatLichHen(d_old,d_new,s_old,s_new,dentist);
            Close();
        }
    }
}
