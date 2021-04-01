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
        public string Duration { get; set; }
        public decimal Price { get; set; }
        public string PriceString { get; set; }
    }
}
