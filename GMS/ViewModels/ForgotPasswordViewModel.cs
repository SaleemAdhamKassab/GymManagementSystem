using System.ComponentModel.DataAnnotations;

namespace GMS.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required, EmailAddress]
        public  string Email { get; set; }
    }
}