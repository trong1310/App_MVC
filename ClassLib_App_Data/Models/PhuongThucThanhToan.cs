using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class PhuongThucThanhToan
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ThanhToan>ThanhToans { get; set; }
    }
}
