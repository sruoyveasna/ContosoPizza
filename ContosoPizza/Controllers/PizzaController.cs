using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
namespace ContosoPizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll()
        {
            var pizzas = Services.PizzaService.GetAll();
            return Ok(pizzas);
        }
    }
}
