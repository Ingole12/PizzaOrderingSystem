using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.Pizza;
using PizzaOrderingSystemAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaOrderingSystemAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {

        private readonly PizzaService _pizzaService;

        public PizzaController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }


        // GET: api/<PizzaController>
        [HttpGet]
        public async Task<IEnumerable<Pizza>> Get()
        {
            return await _pizzaService.GetAll();
        }

        // GET api/<PizzaController>/5
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Pizza>> GetById(int id)
        {
            return await _pizzaService.GetById(id);
        }

        // POST api/<PizzaController>
        [HttpPost]
        public async Task<ActionResult<Pizza>> Post(PizzaDto pizzaDto)
        {
            return await _pizzaService.AddPizzaType(pizzaDto);
        }

        // PUT api/<PizzaController>/5
        [HttpPut]
        [Route("{id:int}")]

        public async Task<ActionResult<Pizza>> Put([FromRoute] int id, PizzaDto pizzaDto)
        {
            return await _pizzaService.UpdatePizza(id, pizzaDto);
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete]
        [Route("{id:int}")]

        public async Task<ActionResult<Pizza>> DeletePizza([FromRoute]int id)
        {
            return await _pizzaService.DeletePizza(id); 
        }
    }
}
