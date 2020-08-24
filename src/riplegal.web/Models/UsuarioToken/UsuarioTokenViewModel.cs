using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riplegal.api.Models.UsuarioToken
{
    public class UsuarioTokenViewModel
    {
        public Guid? IDUser { get; set; }
        public string Token { get; set; }
        public DateTime HoraExpiracion { get; set; }
    }
}
