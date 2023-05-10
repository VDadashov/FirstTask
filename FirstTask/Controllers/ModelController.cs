using FirstTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1, Name = "M5", MarkaId= 1 },
                new Model { Id = 2, Name = "M7", MarkaId= 1 },
                new Model { Id = 3, Name = "458 Italia", MarkaId= 2 },
                new Model { Id = 4, Name = "A 250", MarkaId= 3 },
                new Model { Id = 5, Name = "B 170", MarkaId= 3 },
                new Model { Id = 6, Name = "Q7", MarkaId= 4 },
            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if(_models.Exists(m => m.MarkaId == id)) NotFound();

                return View(_models.FindAll( m => m.MarkaId == id));
            }
            return View(_models);
        }
    }
}
