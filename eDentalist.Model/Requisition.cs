using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class Requisition
    {
        public int RequisitionID { get; set; }
        public int Amount { get; set; }
        public DateTime DateRequisitioned { get; set; }
        public int UserID { get; set; }
        public int? MaterialID { get; set; }
        public int? EquipmentID { get; set; }
    }
}
