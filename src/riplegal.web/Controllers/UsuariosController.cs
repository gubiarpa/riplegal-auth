using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riplegal.api.Models.Usuario;
using riplegal.datos;
using System.Linq;
using System.Threading.Tasks;

namespace riplegal.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DBContextApi _context;

        public UsuariosController(DBContextApi context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Listar()
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            if ((usuarios == null) || (usuarios.Count == 0)) return NotFound();

            var usuariosResponse = usuarios.Select(c => new UsuarioViewModel()
            {
                IDUser = c.IDUser,
                User = c.Nombre,
                Password = c.Password,
                Nickname = c.Nick
            });

            return Ok(usuariosResponse);
        }
    }
}
