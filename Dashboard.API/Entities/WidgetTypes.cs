﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.API.Entities
{
    public class WidgetTypes
    {
        [Key]
        public int WidgetTypesId { get; set; }

        [Required, StringLength(100)]
        public string WidgetTypesName { get; set; }
    }
}
