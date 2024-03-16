using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class SanPham
    {
        public Guid ID { get; set; }
        public string ProductsName { get; set; }
        public string ProductDescription { get; set; }
        public Decimal ProductsPrice { get; set; }
        public string ProductsQuantity { get; set; }
        public int ProductsStatus {  get; set; }
        
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    }
}
