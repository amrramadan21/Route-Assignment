using System.ComponentModel.DataAnnotations;

namespace Demo.Pl.ViewModels.IdentityViewModels
{
    public class ForgetPasswordViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
    }
}
