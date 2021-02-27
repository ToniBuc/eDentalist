using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Bill
    {
        public int BillID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserCountry { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int AppointmentID { get; set; }
        public Appointment Appointment { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
