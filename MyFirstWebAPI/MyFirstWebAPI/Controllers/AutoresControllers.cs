using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Entidades;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresControllers : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() {
                new Autor() { Id = 1, Name = "Salomon" },
                new Autor() { Id = 2, Name = "Alvaro" }
                };
        }
    }
}
