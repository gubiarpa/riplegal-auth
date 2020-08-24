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
    public class SubmodulosController : ApiControllerBase
    {
        public SubmodulosController(DBContextApi context) : base(context)
        {
        }
    }
}
