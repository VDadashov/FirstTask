using FirstTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class MarkaController : Controller
    {
        private readonly List<Marka> _marka;

        public MarkaController()
        {
            _marka = new List<Marka>
            {
                new Marka{ Id = 1, Name = "BMW"},
                new Marka{ Id = 2, Name = "Ferrari"},
                new Marka{ Id = 3, Name = "Mercedes"},
                new Marka{ Id = 4, Name = "Audi"},
            };
        }

        public IActionResult Index()
        {
            return View(_marka);
        }
    }
}
