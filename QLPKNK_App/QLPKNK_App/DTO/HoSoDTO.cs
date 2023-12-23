using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.DTO
{
    public class HoSoDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birth { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public bool gender { get; set; }
    }
}
