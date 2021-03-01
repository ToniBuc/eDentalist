using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class RatingUpsertRequest
    {
        public int ProcedureID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }
        public string Comment { get; set; }
    }
}
