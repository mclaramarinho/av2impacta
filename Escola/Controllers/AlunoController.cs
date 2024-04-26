using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
