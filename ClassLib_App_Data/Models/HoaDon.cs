using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class HoaDon
    {
        public Guid  ID { get; set; }
        public DateTime SolDate { get; set; }
        public Guid UserID { get; set; }
        public Decimal TotalMoney { get; set; }
        public int Status { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
