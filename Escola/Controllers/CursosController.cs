using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
