using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Equipment:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SerialNo { get; set; }
        [ForeignKey("EquipmentType")]
        public int EquipmentTypeId { get; set; }
        public string VendorName { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime WarrantyExpireDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Group Group { get; set; }
        public Location Location { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public ICollection<Maintenance> Maintenance { get; set; }

    }
}
