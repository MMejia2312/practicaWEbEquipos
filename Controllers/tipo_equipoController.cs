using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;

namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tipo_equipoController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public tipo_equipoController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;


        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<tipo_equipo> listadoTipo_equi = (from te in _equiposContexto.tipo_equipo
                                              select te).ToList();
            if (listadoTipo_equi.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoTipo_equi);
        }
    }
}
