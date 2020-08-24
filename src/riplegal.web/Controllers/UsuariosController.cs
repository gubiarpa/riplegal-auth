using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riplegal.api.Controllers.Behavior;
using riplegal.api.Models.Usuario;
using riplegal.api.Models.UsuarioToken;
using riplegal.datos;
using riplegal.datos.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace riplegal.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ApiControllerBase
    {
        public UsuariosController(DBContextApi context) : base(context)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Autenticar(UsuarioLoginViewModel login)
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            if ((usuarios == null) || (usuarios.Count == 0)) return NotFound();

            var usuarioConsultado = usuarios.SingleOrDefault(u => u.Nombre == login.Usuario);
            if (usuarioConsultado == null) return NotFound();

            var verify = StringHash.Verify(login.Clave, usuarioConsultado.Password);

            Guid? idUser = null;
            string token = null;
            DateTime horaExpiracion = login.HoraLogin ?? DateTime.Now;

            if (verify)
            {
                idUser = usuarioConsultado.Id;
                token = TokenGenerator.Generate();
                horaExpiracion = horaExpiracion.AddMinutes(30);
            }

            var tokenResponse = new UsuarioTokenViewModel()
            {
                IDUser = idUser,
                Token = token,
                HoraExpiracion = horaExpiracion
            };
            
            return Ok(tokenResponse);
        }
    }
}
