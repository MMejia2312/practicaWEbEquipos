using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaWEbEquipos.Models;
using Microsoft.EntityFrameworkCore;
namespace practicaWEbEquipos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public usuariosController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;


        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<usuarios> listadoUsuarios = (from lu in _equiposContexto.usuarios
                                          select lu).ToList();
            if (listadoUsuarios.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoUsuarios);
        }
    }
}