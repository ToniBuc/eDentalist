using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class RequisitionUpdateRequest
    {
        public int Amount { get; set; }
        public DateTime DateRequisitioned { get; set; }
        public int UserID { get; set; }
        public string ItemName { get; set; }
    }
}
