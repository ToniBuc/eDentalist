using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDentalist.Model
{
    public class Procedure
    {
        public int ProcedureID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Price { get; set; }
        public string PriceString { get; set; }
    }
}
