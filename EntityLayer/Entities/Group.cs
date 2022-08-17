using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
    }
}
