using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class HygieneProcessUpsertRequest
    {
        public DateTime DateOfPerformance { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public int HygieneProcessTypeID { get; set; }
        public bool Status { get; set; }
    }
}
