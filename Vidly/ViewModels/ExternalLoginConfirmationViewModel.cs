using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Carteira de Motorista")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
    }
}