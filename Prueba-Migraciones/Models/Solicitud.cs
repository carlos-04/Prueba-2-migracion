using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Migraciones.Models
{
    public class Solicitud
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public int PersonaId { get; set; }
             
    }
}
