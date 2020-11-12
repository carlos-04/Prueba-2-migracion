using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
  public  class Solicitud
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
       
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Persona persona { get; set; }
    }
}
