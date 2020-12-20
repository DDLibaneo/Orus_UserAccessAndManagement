﻿using System.ComponentModel.DataAnnotations;

namespace Orus_UserAccessAndManagement.ViewModels.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
