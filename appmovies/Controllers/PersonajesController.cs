using Microsoft.AspNetCore.Mvc;

namespace appmovies.Controllers
{
    public class PersonajesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
