using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;

namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class estados_reservaController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public estados_reservaController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;

        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<estado_reserva> listadoRes = (from estRe in _equiposContexto.estados_reserva
                                          select estRe).ToList();
            if (listadoRes.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoRes);
        }
    }
}
