using System;
using System.ComponentModel.DataAnnotations;

namespace riplegal.api.Models.Modulo
{
    public class ModuloViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
