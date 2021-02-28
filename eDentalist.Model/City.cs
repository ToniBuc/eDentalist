using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public string ZIPCode { get; set; }
    }
}
