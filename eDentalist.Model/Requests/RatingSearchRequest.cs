using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class RatingSearchRequest
    {
        public int? RatingID { get; set; }
        public int? ProcedureID { get; set; }
        public int? UserID { get; set; }
    }
}
