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
    public class PerfilesController : ApiControllerBase
    {
        public PerfilesController(DBContextApi context) : base(context)
        {
        }
    }
}
