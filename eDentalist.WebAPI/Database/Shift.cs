using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public int ShiftNumber { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}