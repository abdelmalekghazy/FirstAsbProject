using Microsoft.AspNetCore.Mvc;

namespace FirstAsbProject.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
