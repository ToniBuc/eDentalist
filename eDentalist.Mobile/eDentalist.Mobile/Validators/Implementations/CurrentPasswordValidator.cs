using eDentalist.Mobile.Validators.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Mobile.Validators.Implementations
{
    public class CurrentPasswordValidator : IValidator
    {
        public string Message { get; set; } = "The entered password does not match your current password!";

        public bool Check(string value)
        {
            return value == APIService.Password;
        }
    }
}
