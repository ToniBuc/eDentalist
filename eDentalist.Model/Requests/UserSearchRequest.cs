using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class UserSearchRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //for reports
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
