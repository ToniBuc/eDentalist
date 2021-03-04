using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JMBG { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int UserRoleID { get; set; }
        public UserRole UserRole { get; set; }
        public string UserRoleName { get; set; }
        public int GenderID { get; set; }
        public Gender Gender { get; set; }
        public string GenderName { get; set; }
        public string Username { get; set; }
        public int CityID { get; set; }
    }
}
