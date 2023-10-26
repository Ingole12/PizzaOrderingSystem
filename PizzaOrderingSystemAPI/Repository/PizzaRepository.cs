using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemAPI.DBContext;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.Pizza;
using System.Reflection.Metadata.Ecma335;

namespace PizzaOrderingSystemAPI.Repository
{
    public class PizzaRepository
    {
        private readonly PizzaOrderingSystemAPI_DbContext _context;

        public PizzaRepository(PizzaOrderingSystemAPI_DbContext pizzaOrderingSystemAPI_DbContext)
        {
            _context = pizzaOrderingSystemAPI_DbContext;
        }

        public async Task<IEnumerable<Pizza>> GetAll()
        {
            return await _context.Pizza.ToListAsync();
        }

        public async Task<ActionResult<Pizza>> GetById(int id)
        {
            return await _context.Pizza.FindAsync(id);
        }

        public async Task<ActionResult<Pizza>> AddPizzaType(PizzaDto pizzaDto)
        {
            var AddPizza = new Pizza
            {
                pizzaName = pizzaDto.pizzaName,
                pizzaAmount = pizzaDto.pizzaAmount
            };

            _context.Pizza.Add(AddPizza);
            _context.SaveChanges();
            return AddPizza;
        }

        public async Task<ActionResult<Pizza>> UpdatePizza(int id, PizzaDto pizzaDto)
        {
            var updatedPizza = await _context.Pizza.FindAsync(id);

            if (updatedPizza != null)
            {
                updatedPizza.pizzaName = pizzaDto.pizzaName;
                updatedPizza.pizzaAmount = pizzaDto.pizzaAmount;
            }

            _context.SaveChanges();
            return updatedPizza;
        }

        public async Task<ActionResult<Pizza>> DeletePizza (int id)
        {
            var updatedPizza = await _context.Pizza.FindAsync(id);
            if (updatedPizza != null)
            {
                _context.Remove(updatedPizza);
                _context.SaveChanges();
                return updatedPizza;
            }
            else
            {
                return null;
            }
        }
    }
}
