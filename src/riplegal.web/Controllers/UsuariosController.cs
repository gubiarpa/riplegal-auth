using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riplegal.api.Controllers.Behavior;
using riplegal.api.Models.Usuario;
using riplegal.datos;
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

        //[HttpGet("action")]
        //public async Task<IActionResult> Autenticar()
        //{
        //    return Ok(new { c = 9 });
        //}

        [HttpGet("[action]")]
        public async Task<IActionResult> Listar()
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            if ((usuarios == null) || (usuarios.Count == 0)) return NotFound();

            var usuariosResponse = usuarios.Select(u => new UsuarioViewModel()
            {
                IdUser = u.Id,
                User = u.Nombre,
                Password = u.Password,
                Nickname = u.Nick
            });

            return Ok(usuariosResponse);
        }
    }
}
