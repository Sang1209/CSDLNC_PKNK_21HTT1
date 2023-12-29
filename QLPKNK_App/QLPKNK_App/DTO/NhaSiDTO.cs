using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.DTO
{
    public class NhaSiDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public bool gender { get; set; }
        public int depID { get; set; }
        public string dep_addr { get; set; }
    }
}
