using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riplegal.api.Models.Usuario
{
    public class UsuarioLoginViewModel
    {
        public string CodSistema { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public DateTime? HoraLogin { get; set; }
    }
}
