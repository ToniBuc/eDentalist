using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Procedure
    {
        public int ProcedureID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
