using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;

namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class estado_reservaController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public estado_reservaController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;

        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<estado_reserva> listadoEReservas = (from eRes in _equiposContexto.estados_reserva
                                          select eRes).ToList();
            if (listadoEReservas.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoEReservas);
        }
    }
}
