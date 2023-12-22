using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.DTO
{
    public class LichHenDTO
    {
        public DateTime date { get; set; }
        public int shiftId { get; set; }
        public TimeSpan start { get; set; }
        public TimeSpan finish { get; set; }
        public string dentist { get; set; }
        public int patient { get; set; }
        public string assistant { get; set; }
        public int type { get; set; }
        public int depId { get; set; }
        public string DepAddress { get; set; }
    }
}
