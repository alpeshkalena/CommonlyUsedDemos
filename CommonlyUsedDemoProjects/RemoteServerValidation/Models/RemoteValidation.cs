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
    }
}
