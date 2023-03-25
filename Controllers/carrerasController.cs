using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;

namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class carrerasController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public carrerasController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;

        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<carreras> listadoCarreras = (from ca in _equiposContexto.carreras
                                          select ca).ToList();
            if (listadoCarreras.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoCarreras);
        }
    }
}
