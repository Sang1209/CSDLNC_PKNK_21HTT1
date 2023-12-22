using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.DTO
{
    public class HoaDonDTO
    {
        public int treatment { get; set; }
        public int times { get; set; }
        public double total { get; set; }
        public double given { get; set; }
        public string method { get; set; }
        public DateTime date { get; set; }
        public string payer { get; set; }
        public string note { get; set; }
    }
}
