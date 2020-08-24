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

        [HttpPost("[action]")]
        public async Task<IActionResult> Autenticar()
        {
            return Ok(new { c = 9 });
        }
    }
}
