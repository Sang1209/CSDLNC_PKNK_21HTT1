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
    public partial class AddSchedule : Form
    {
        public NhaSiDTO nhasi { get; set; }
        public AddSchedule()
        {
            InitializeComponent();
        }
        public AddSchedule(NhaSiDTO nhasi)
        {
            InitializeComponent ();
            this.nhasi = nhasi;
            AddScheduleTitle.Text = "Add free schedule";
            ShiftID.ValueChanged += new EventHandler(capNhatTG);
        }
        public AddSchedule(int treatmentID,int patientID,NhaSiDTO ns)
        {
            InitializeComponent();
            this.nhasi=ns;
            AddScheduleTitle.Text = "Add re-examination schedule";
            tId.Value = treatmentID;
            pId.Value = patientID;
        }
        private void capNhatTG(object sender, EventArgs e)
        {
            int shift =Convert.ToInt32(ShiftID.Value);
            CaBUS caBUS = new CaBUS();
            CaDTO ca=caBUS.LayTTCa(shift);
            fromTime.Text=ca.start.ToString();
            toTime.Text=ca.finish.ToString();
        }
        private void AddShcedule_Load(object sender, EventArgs e)
        {
            assistantCB.DisplayMember="name";
            NhaSiBUS bus = new NhaSiBUS();
            IList<NhaSiDTO> dsNhaSi = bus.layDSNhaSi();
            dentistName.Text=nhasi.name;
            assistantCB.Items.AddRange(dsNhaSi.ToArray<NhaSiDTO>());
            assistantCB.KeyDown += new KeyEventHandler(keydownEvt);
            if (assistantCB.Items.Count > 0)
            {
                assistantCB.SelectedIndex = 0;
            }

        }
        private void keydownEvt(object sender, KeyEventArgs e)
        {
            assistantCB.DroppedDown=false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            LichHenBUS lichHenBUS = new LichHenBUS();
            DateTime d = date.Value;
            int s = Convert.ToInt32(ShiftID.Value);
            string dentist = nhasi.username;
            string assistant=((NhaSiDTO)assistantCB.SelectedItem).username;
            int depId = nhasi.depID;
            int treatmentID = (int)tId.Value;
            int patientID=(int)pId.Value;
            if(treatmentID!=-1)
            {
                lichHenBUS.taoLichTaiKham(d,s,dentist,patientID,assistant,treatmentID);
            }
            else
            {
                lichHenBUS.taoLichHen(d, s, dentist, assistant, depId);
            }
            Close();
        }
    }
}
