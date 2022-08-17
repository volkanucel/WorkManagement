using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class WorkOrder:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("AppUser")]
        public string AssignedUserId { get; set; }
        public DateTime WorkOrderOpenDate { get; set; }
        public DateTime WorkOrderCloseDate { get; set; }
        public int WorkOrderCreatorUserId { get; set; }
        public bool Status { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<Maintenance> Maintenance { get; set; }


    }
}
