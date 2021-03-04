using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class UserUpdateRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string JMBG { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }
        public int UserRoleID { get; set; }
        public int GenderID { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public int CityID { get; set; }
    }
}
