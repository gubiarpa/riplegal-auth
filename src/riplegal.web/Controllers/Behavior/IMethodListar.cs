using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace riplegal.api.Controllers.Behavior
{
    public interface IMethodListar
    {
        Task<IActionResult> Listar();
    }
}
