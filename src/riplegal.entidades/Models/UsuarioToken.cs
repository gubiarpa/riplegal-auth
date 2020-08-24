using riplegal.entidades.Models.Behavior;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace riplegal.entidades.Models
{
    public class UsuarioToken : IGuid
    {
        [Column("IDToken")]
        public Guid Id { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public Guid IDUser { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
