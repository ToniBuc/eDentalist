using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class HygieneProcess
    {
        public int HygieneProcessID { get; set; }
        public DateTime DateOfPerformance { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public int HygieneProcessTypeID { get; set; }
        public bool Status { get; set; }
    }
}
