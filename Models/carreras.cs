﻿using System.ComponentModel.DataAnnotations;
namespace practicaWEbEquipos.Models
{
    public class carreras
    {
        public int carrera_id { get; set; }
        public string nombre_carrera { get; set; }
        public int facultad_id { get; set; }
    }
}
