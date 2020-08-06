using System;
using System.ComponentModel.DataAnnotations;

namespace riplegal.api.Models.Usuario
{
    public class UsuarioViewModel
    {
        [Required]
        public Guid IDUser { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Nickname { get; set; }
    }
}
