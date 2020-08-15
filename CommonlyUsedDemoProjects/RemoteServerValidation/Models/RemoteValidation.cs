using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteServerValidation.Models
{
    public class RemoteValidation
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Remote("CheckDuplicateEmail", "Home",HttpMethod ="POST",ErrorMessage ="Email Already Exists!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "First is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last is required")]
        public string LastName { get; set; }

        //For Phone number validation we need only regex on model

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
    }
}
