using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
using ContosoPizza.Services;
namespace ContosoPizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll()
        {
            var pizzas = PizzaService.GetAll();
            return Ok(pizzas);
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Pizza> GetById(int id)
        {
            var pizza = PizzaService.GetById(id);
            if (pizza == null)
            {
                return NotFound();
            }
            return Ok(pizza);
        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(GetById), new { id = pizza.Id }, pizza);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.GetById(id);
            if (pizza == null)
            {
                return NotFound();
            }
            PizzaService.Delete(id);
            return NoContent();
        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return BadRequest();
            }
            var existingPizza = PizzaService.GetById(id);
            if (existingPizza == null)
            {
                return NotFound();
            }
            PizzaService.Update(pizza);
            return NoContent();
        }
    }
}
