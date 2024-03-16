using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class ThanhToan
    {
        public Guid ID { get; set; }
        public  DateTime Date { get; set; }
        public decimal TotalMoney {  get; set; }
        public int Status {  get; set; }
        public Guid HoaDonID { get; set; }
        public Guid PhuongThucID { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual PhuongThucThanhToan PhuongThucThanhToan { get; set; }
    }
}
