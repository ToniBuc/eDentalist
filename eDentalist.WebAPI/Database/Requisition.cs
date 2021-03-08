using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Requisition
    {
        public int RequisitionID { get; set; }
        public int Amount { get; set; }
        public DateTime DateRequisitioned { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int? MaterialID { get; set; }
        public Material Material { get; set; }
        public int? EquipmentID { get; set; }
        public Equipment Equipment { get; set; }
        public bool Status { get; set; }
    }
}
