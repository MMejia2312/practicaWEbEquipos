using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;

namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class reservasController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public reservasController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;


        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<reservas> listadoRes = (from res in _equiposContexto.reservas
                                          select res).ToList();
            if (listadoRes.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoRes);
        }
    }
}
