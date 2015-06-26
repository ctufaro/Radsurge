using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;

namespace Radsurge.MVC.Models
{
    public class RegisterModels
    {
        [Required(ErrorMessage="Please select a role")]
        public string Role { get; set; }        
        
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("Password", ErrorMessage = "Password and confirm password do not match.")]
        public string Confirm { get; set; }
    }
}