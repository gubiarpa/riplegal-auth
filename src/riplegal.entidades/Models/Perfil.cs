using riplegal.entidades.Models.Behavior;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace riplegal.entidades.Models
{
    public class Perfil : IGuid
    {
        [Column("IDPerfil")]
        public Guid Id { get; set; }
        [Required]
        [Column("Descripcion")]
        public string Nombre { get; set; }
    }
}
