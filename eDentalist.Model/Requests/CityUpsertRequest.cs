using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class CityUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required]
        public int CountryID { get; set; }
        public string ZIPCode { get; set; }
    }
}
