using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DBContext;

namespace PizzaOrderingSystemAPI.Repository
{
    public class LoginUserRepository
    {
        private PizzaOrderingSystemAPI_DbContext _dbcontext;
        public LoginUserRepository(PizzaOrderingSystemAPI_DbContext DbContext)
        {
            _dbcontext = DbContext;
        }

        //public IActionResult CheckValidUser(string username, string password)
        //{
            
        //}
    }
}
