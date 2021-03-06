using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class HygieneProcessUpsertRequest
    {
        [Required]
        public DateTime DateOfPerformance { get; set; }
        public string Description { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int HygieneProcessTypeID { get; set; }
        public bool Status { get; set; }
    }
}
