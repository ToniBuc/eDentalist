using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class Procedure
    {
        public int ProcedureID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
