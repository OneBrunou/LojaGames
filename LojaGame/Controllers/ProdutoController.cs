using Microsoft.AspNetCore.Mvc;

namespace LojaGame.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Produto()
        {
            return View();
        }
    }
}
