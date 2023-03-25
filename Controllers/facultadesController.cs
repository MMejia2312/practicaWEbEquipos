using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;
namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class facultadesController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public facultadesController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;

        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<facultades> listadoFacultades = (from fac in _equiposContexto.facultades
                                          select fac).ToList();
            if (listadoFacultades.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoFacultades);
        }
    }
}
