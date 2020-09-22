using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SteekiT.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Category Name")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
