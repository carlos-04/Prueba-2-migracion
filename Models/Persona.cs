using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Persona
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaNac { get; set; }
        [Required]
        [StringLength(100)]
        public string Pasaporte { get; set; }
        [Required]
        [StringLength(150)]
        public string Direccion { get; set; }
        [Required]
        [StringLength(50)]
        public string Sexo { get; set; }

        public List<Solicitud>  Solicitudes { get; set; }

    }
}
