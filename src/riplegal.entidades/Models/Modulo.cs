using riplegal.entidades.Models.Behavior;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace riplegal.entidades.Models
{
    public class Modulo : IGuid
    {
        [Column("IDModulo")]
        public Guid Id { get; set; }
        [Required]
        [Column("Descripcion")]
        public string Nombre { get; set; }
        [Required]
        [Column("IDSistema")]
        public Guid IdSistema { get; set; }
    }
}
