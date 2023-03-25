using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;

namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class marcaController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public marcaController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;

        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<marcas> listadoMarcas = (from m in _equiposContexto.marcas
                                           select m).ToList();
            if (listadoMarcas.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoMarcas);
        }
    }
}
