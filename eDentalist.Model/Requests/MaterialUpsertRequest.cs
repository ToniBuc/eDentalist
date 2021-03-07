using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class MaterialUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public DateTime LastUsed { get; set; }
        public string Description { get; set; }
    }
}
