using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.Pizza;
using PizzaOrderingSystemAPI.Repository;

namespace PizzaOrderingSystemAPI.Services
{
    public class PizzaService
    {
        private readonly PizzaRepository _repository;

        public PizzaService( PizzaRepository pizzaRepository)
        {
            _repository = pizzaRepository;
        }

        public Task<IEnumerable<Pizza>> GetAll() 
        { 
           return _repository.GetAll();
        }

        public Task<ActionResult<Pizza>> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<ActionResult<Pizza>> AddPizzaType(PizzaDto pizzaDto)
        {
            return await _repository.AddPizzaType(pizzaDto);
        }
        public async Task<ActionResult<Pizza>> UpdatePizza(int id, PizzaDto pizzaDto)
        {
            return await _repository.UpdatePizza(id, pizzaDto);
        }

        public async Task<ActionResult<Pizza>> DeletePizza(int id)
        {
            return await _repository.DeletePizza(id);
        }
    }
}
