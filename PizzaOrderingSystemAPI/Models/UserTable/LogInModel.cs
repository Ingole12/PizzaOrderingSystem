using System.ComponentModel.DataAnnotations;

namespace PizzaOrderingSystemAPI.Models.UserTable
{
    public class LogInModel
    {
        [Required (ErrorMessage ="Application User Name is Required")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Application Password is Required")]
        public string ? Password { get; set; }
    }
}
