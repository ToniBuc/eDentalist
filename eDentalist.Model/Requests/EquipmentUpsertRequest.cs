﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class EquipmentUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUsed { get; set; }
        public string Description { get; set; }
        public bool Condition { get; set; }
        public int Amount { get; set; }
        public int EquipmentTypeID { get; set; }
    }
}
