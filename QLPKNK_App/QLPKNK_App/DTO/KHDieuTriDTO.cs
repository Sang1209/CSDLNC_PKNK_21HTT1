using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace buhbuhlmao.BUS
{
    public class KHDieuTriDTO
    {
        public int id { get; set; }
        public string department { get; set; }
        public string dentist { get; set; }
        public string den_name { get; set; }
        public int patient { get; set; }
        public string pat_name { get; set; }
        public string assistant { get; set; }
        public string ass_name { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public string note { get; set; }
        public string method { get; set; }
        public string tooth_name { get; set; }
        public int state { get; set; }
        public double total { get; set; }
        public KHDieuTriDTO(int id, string department, string dentist, int patient, string assistant, string description, DateTime date, string note, string method, string tooth_name, int state, double total)
        {
            this.id = id;
            this.department = department;
            this.dentist = dentist;
            this.patient = patient;
            this.assistant = assistant;
            this.description = description;
            this.date = date;
            this.note = note;
            this.method = method;
            this.tooth_name = tooth_name;
            this.state = state;
            this.total = total;
        }

        public KHDieuTriDTO() { }
    }
}
