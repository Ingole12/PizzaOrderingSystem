using System.ComponentModel.DataAnnotations;

namespace PizzaOrderingSystemAPI.Models.UserTable
{
    public class RegistrationModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "User Name is Required")]
        public string UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        public string Designation { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
