using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class EquipmentSearchRequest
    {
        public int? EquipmentID { get; set; }
        public string Name { get; set; }
        //for reports
        public int? EquipmentTypeID { get; set; }
    }
}
