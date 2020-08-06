using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riplegal.api.Controllers.Behavior;
using riplegal.api.Models.Perfil;
using riplegal.datos;
using System.Linq;
using System.Threading.Tasks;

namespace riplegal.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilesController : ApiControllerBase, IMethodListar
    {
        public PerfilesController(DBContextApi context) : base(context)
        {
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Listar()
        {
            var perfiles = await _context.Perfiles.ToListAsync();

            if ((perfiles == null) || (perfiles.Count == 0)) return NotFound();

            var perfilesResponse = perfiles.Select(p => new PerfilViewModel()
            {
                Id = p.Id,
                Nombre = p.Nombre
            });

            return Ok(perfilesResponse);
        }
    }
}
