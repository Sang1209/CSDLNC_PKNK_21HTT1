using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.DTO
{
    public class DonThuocDTO
    {
        public string medicineId { get; set; }
        public String medicineName { get; set; }
        public int quantity { get; set; }
        public String note { get; set; }
        public DonThuocDTO() { }
        public DonThuocDTO(string medicineId, string medicineName, int quantity, string note)
        {
            this.medicineId = medicineId;
            this.medicineName = medicineName;
            this.quantity = quantity;
            this.note = note;
        }
    }
}
