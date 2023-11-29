using System.ComponentModel.DataAnnotations;

namespace PizzaOrderingSystemAPI.Models.UserTable
{
    public class ApplicationUserModel
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }  
    }
}
