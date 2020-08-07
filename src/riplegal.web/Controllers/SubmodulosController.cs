using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riplegal.api.Controllers.Behavior;
using riplegal.api.Models.Submodulo;
using riplegal.datos;

namespace riplegal.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmodulosController : ApiControllerBase, IMethodListar
    {
        public SubmodulosController(DBContextApi context) : base(context)
        {
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Listar()
        {
            var submodulos = await _context.Submodulos.ToListAsync();

            if ((submodulos == null) || (submodulos.Count == 0)) return NotFound();

            var submodulosResponse = submodulos.Select(s => new SubmoduloViewModel()
            {
                Id = s.Id,
                Nombre = s.Nombre,
                IdModulo = s.IdModulo
            });

            return Ok(submodulosResponse);
        }
    }
}
