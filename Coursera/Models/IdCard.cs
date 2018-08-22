using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursera.Models {
    public class IdCard {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdNumber { get; set; }

        [Required]
        public string Picture { get; set; }

        [Required]
        [MaxLength(255)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(255)]
        public string Lastname { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }
    }
}