using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUsed { get; set; }
        public string Description { get; set; }
        public bool Condition { get; set; }
        public int Amount { get; set; }
        public int EquipmentTypeID { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public string EquipmentTypeName { get; set; }
        //for reports
        public string DateAddedString { get; set; }
        public string LastUsedString { get; set; }
    }
}
