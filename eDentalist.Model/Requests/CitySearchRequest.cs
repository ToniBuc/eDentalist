using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class CitySearchRequest
    {
        //public int? CityID { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
    }
}
