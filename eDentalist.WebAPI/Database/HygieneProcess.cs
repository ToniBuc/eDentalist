using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class HygieneProcess
    {
        public int HygieneProcessID { get; set; }
        public DateTime DateOfPerformance { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int HygieneProcessTypeID { get; set; }
        public HygieneProcessType HygieneProcessType { get; set; }
        public bool Status { get; set; }
    }
}
