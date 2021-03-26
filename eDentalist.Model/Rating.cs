using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int ProcedureID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }
        public string Comment { get; set; }
    }
}
