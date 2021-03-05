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
        public User User { get; set; }
        public string StaffName { get; set; }
        public int HygieneProcessTypeID { get; set; }
        public HygieneProcessType HygieneProcessType { get; set; } //
        public string HygieneProcessTypeName { get; set; } //
        public bool Status { get; set; }
    }
}
