using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class HoaDonChiTiet
    {
        public Guid  ID{ get; set; }
        public Guid HoaDonID { get; set; }
        public Guid ProductsID { get; set; }
        public Decimal ProductsPrice { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
