using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Models
{
    public class Roles
    {
        public Guid ID { get; set; }
        public string RolesName { get; set; }
        public string Role { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
