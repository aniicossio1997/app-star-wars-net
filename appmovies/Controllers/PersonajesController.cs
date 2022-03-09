using appmovies.Models;
using Microsoft.AspNetCore.Mvc;

namespace appmovies.Controllers
{
    public class PersonajesController : Controller
    {
        public  StartwarsDb Ctx { get; set; }

        public PersonajesController(StartwarsDb ctx)
        {
            Ctx = ctx;
        }
        public IActionResult Listado()
        {
            var model = new PersonajesListadoModel();
            model.Listado = Ctx.Personajes.ToList();
            return View(model);
        }
        public IActionResult Index( string id, string name)
        {
            if (!string.IsNullOrEmpty(id))
            {
                int Id = 0;
                if (int.TryParse(id, out Id)) {
                    Ctx.Personajes.Add(new Personaje { Id = Id, Name = name });
                    Ctx.SaveChanges();
                }
            }
           /*
            * var db = new StartwarsDb();
            var personajes = db.Personajes.ToList();
           */
            return View();
        }
    



    }
}
