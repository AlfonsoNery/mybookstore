using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mybookstore.Models
{
    public class AuthorsModels
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(40, ErrorMessage = "Up to 40 chars only!")]
        [Required(ErrorMessage = "REQUIRED!!!")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(20, ErrorMessage = "Up to 20 chars only!")]
        [Required(ErrorMessage = "REQUIRED!!!")]
        public string FirstName  { get; set; }

        [Display(Name = "Phone")]
        [MaxLength(12, ErrorMessage = "Up to 12 chars only!")]
        [Required(ErrorMessage = "REQUIRED!!!")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(40, ErrorMessage = "Up to 40 chars only!")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [MaxLength(20, ErrorMessage = "Up to 20 chars only!")]
        public string City { get; set; }

        [Display(Name = "State")]
        [MaxLength(2, ErrorMessage = "Up to 2 chars only!")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [MaxLength(5, ErrorMessage = "Up to 5 chars only!")]
        public string Zip { get; set; }


    }
}