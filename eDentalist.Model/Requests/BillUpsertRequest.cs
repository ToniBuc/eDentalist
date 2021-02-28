using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class BillUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string UserFirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserCountry { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }
        public int UserID { get; set; }
        public int AppointmentID { get; set; }
        public int CityID { get; set; }
        public int CountryID { get; set; }
    }
}
