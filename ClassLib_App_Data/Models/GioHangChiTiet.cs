using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class GioHangChiTiet
    {
        public Guid ID { get; set; }
        public int Quantity {  get; set; }
        public Guid CartID { get; set; }
        public Guid ProductsID { get; set; }
        public virtual GioHang GioHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
