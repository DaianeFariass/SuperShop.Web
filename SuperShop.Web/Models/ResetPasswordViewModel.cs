﻿using System.ComponentModel.DataAnnotations;

namespace SuperShop.Web.Models
{
    public class ResetPasswordViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Token { get; set; }   
    }
}
