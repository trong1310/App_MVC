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
        public string ProductsImages { get; set; }

        public int ProductsStatus {  get; set; }
        public Guid DanhMucID { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
       public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    }
}
