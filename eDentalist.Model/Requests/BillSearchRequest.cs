using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class BillSearchRequest
    {
        public int? BillID { get; set; }
        public int? PatientID { get; set; }
        //for reports
        public bool Status { get; set; }
        public string StatusString { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string PatientName { get; set; }
    }
}
