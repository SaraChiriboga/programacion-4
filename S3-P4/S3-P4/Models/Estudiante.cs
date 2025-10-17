using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace S3_P4.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Range(18, 99)]
        public int Edad { get; set; }

        public string Carrera { get; set; }
    }
}