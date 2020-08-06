using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riplegal.api.Controllers.Behavior;
using riplegal.api.Models.Modulo;
using riplegal.datos;
using System.Linq;
using System.Threading.Tasks;

namespace riplegal.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulosController : ApiControllerBase, IMethodListar
    {
        public ModulosController(DBContextApi context) : base(context)
        {
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Listar()
        {
            var modulos = await _context.Modulos.ToListAsync();

            if ((modulos == null) || (modulos.Count == 0)) return NotFound();

            var modulosResponse = modulos.Select(m => new ModuloViewModel()
            {
                Id = m.Id,
                Nombre = m.Nombre
            });

            return Ok(modulosResponse);
        }
    }
}
