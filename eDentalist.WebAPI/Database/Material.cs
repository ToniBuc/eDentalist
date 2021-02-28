using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUsed { get; set; }
        public string? Description { get; set; }
    }
}
