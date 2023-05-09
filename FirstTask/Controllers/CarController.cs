using FirstTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new List<Car>
            {
                new Car{ Id = 1,Color = "Black", Engine = "2.4l", Year = 2014, ModelId = 1 },
                new Car{ Id = 2,Color = "Red", Engine = "3.2l", Year = 2016, ModelId = 1 },
                new Car{ Id = 3,Color = "White", Engine = "3.1l", Year = 2010, ModelId = 2 },
                new Car{ Id = 4,Color = "Brown", Engine = "3.3l", Year = 2011, ModelId = 2 },
                new Car{ Id = 5,Color = "Black", Engine = "2.1l", Year = 2012, ModelId = 3 },
                new Car{ Id = 5,Color = "Yellow", Engine = "2.5l", Year = 2015, ModelId = 3 },
                new Car{ Id = 7,Color = "Green", Engine = "2.7l", Year = 2014, ModelId = 4 },
                new Car{ Id = 8,Color = "Brown", Engine = "2.8l", Year = 2015, ModelId = 4 },
                new Car{ Id = 9,Color = "Red", Engine = "2.35l", Year = 2016, ModelId = 5 },
                new Car{ Id = 10,Color = "Purple", Engine = "2.2l", Year = 2011, ModelId = 5 },
                new Car{ Id = 11,Color = "Yellow", Engine = "3.4l", Year = 2019, ModelId = 6 },
                new Car{ Id = 12,Color = "White", Engine = "2.8l", Year = 2014, ModelId = 6 },
            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (_cars.Exists(m => m.Id == id)) NotFound();

                return View(_cars.FindAll(m => m.ModelId == id));
            }
            return View(_cars);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) BadRequest();

            Car car = _cars.Find(c => c.Id == id);

            if (car == null) return NotFound(); 

            return View(car);
        }
    }
}
