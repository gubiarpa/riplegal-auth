using Microsoft.AspNetCore.Mvc;
using riplegal.datos;

namespace riplegal.api.Controllers.Behavior
{
    public abstract class ApiControllerBase : ControllerBase
    {
        protected readonly DBContextApi _context;

        public ApiControllerBase(DBContextApi context)
        {
            _context = context;
        }
    }
}
