using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class User
    {
       public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime DoB { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        // ICollection<HoaDon> HoaDons chi de the hien 1 user co the co nhieu hoa don
        // ICollection<HoaDon> HoaDons con duoc su dung de lam Navigation de tro den khi can
        // 
    }
}
