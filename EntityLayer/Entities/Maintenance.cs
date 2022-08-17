using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Maintenance:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Equipment")]
        public int  EquipmentId { get; set; }
        [ForeignKey("WorkOrder")]
        public int  WorkOrderId { get; set; }
        public string  Status { get; set; }
        public Equipment Equipment { get; set; }
        public WorkOrder WorkOrder { get; set; }
    }
}
