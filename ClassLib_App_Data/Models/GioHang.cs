using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class GioHang
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }

        public virtual User User { get; set; }  
       public virtual ICollection<GioHangChiTiet>GioHangChiTiets { get; set; }
    }
}
