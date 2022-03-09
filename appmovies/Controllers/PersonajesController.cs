using appmovies.Models;
using Microsoft.AspNetCore.Mvc;

namespace appmovies.Controllers
{
    public class PersonajesController : Controller
    {
        public IActionResult Index()
        {
            var db = new StartwarsDb();
            var personajes = db.Personajes.ToList();
            return View();
        }
    }
}
