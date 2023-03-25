using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;

namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class estados_equipoController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public estados_equipoController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;


        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<estado_equipo> listadoEstad_equip = (from StE in _equiposContexto.estados_equipos
                                              select StE).ToList();
            if (listadoEstad_equip.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoEstad_equip);
        }
    }
}
