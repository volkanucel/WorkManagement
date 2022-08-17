﻿using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Project:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
