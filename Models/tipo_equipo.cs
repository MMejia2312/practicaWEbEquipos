using System.ComponentModel.DataAnnotations;
namespace practicaWEbEquipos.Models
{
    public class tipo_equipo
    {
        public int id_tipo_equipo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
