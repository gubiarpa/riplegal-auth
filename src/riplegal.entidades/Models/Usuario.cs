using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace riplegal.entidades.Models
{
    public class Usuario
    {
        public Guid IDUser { get; set; }
        [Required]
        [Column("Usuario")]
        public string Nombre { get; set; }
        [Required]
        public string Password { get; set; }
        public string Nick { get; set; }
    }
}
