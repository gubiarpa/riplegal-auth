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
    public class ModulosController : ApiControllerBase
    {
        public ModulosController(DBContextApi context) : base(context)
        {
        }
    }
}
