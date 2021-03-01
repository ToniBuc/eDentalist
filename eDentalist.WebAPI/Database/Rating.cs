using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int ProcedureID { get; set; }
        public Procedure Procedure { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }
        public string? Comment { get; set; }
    }
}
