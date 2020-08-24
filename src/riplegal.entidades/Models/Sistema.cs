using riplegal.entidades.Models.Behavior;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace riplegal.entidades.Models
{
    public class Sistema : IGuid
    {
        [Column("IdSistema")]
        public Guid Id { get; set; }
        [Required]
        [Column("Descripcion")]
        public string Nombre { get; set; }
    }
}
