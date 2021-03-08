using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class RequisitionInsertRequest
    {
        public int Amount { get; set; }
        public DateTime DateRequisitioned { get; set; }
        public int UserID { get; set; }
        public int? MaterialID { get; set; }
        public Material Material { get; set; }
        public int? EquipmentID { get; set; }
        public Equipment Equipment { get; set; }
        public string ItemName { get; set; }
    }
}
