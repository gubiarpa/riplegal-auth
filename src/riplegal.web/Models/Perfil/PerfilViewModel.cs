using System;
using System.ComponentModel.DataAnnotations;

namespace riplegal.api.Models.Perfil
{
    public class PerfilViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
