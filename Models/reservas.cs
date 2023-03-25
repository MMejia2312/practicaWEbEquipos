using System.ComponentModel.DataAnnotations;
namespace practicaWEbEquipos.Models
{
    public class reservas
    {
        public int reserva_id { get; set; }
        public int equipo_id { get; set; }
        public int usuario_id { get; set; }
        public DateTime fecha_salida { get; set; }
        public DateTime hora_salida { get; set; }
        public int timpo_reserva { get; set; }
        public int estado_id { get; set; }
        public DateTime fecha_retorno { get; set; }
        public DateTime hora_retorno { get; set; }
    }
}
