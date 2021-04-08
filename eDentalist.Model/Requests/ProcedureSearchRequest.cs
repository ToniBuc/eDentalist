using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class ProcedureSearchRequest
    {
        public int? ProcedureID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
