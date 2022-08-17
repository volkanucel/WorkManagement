using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime JoinDate { get; set; }
        public string Title { get; set; }
        public ICollection<Training> Training { get; set; }
        public ICollection<WorkOrder> WorkOrder { get; set; }


    }
}
