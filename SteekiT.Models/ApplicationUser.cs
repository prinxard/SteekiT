using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SteekiT.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string StreetAdderss { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        
        [NotMapped]
        public string Role { get; set; }
    }
}
