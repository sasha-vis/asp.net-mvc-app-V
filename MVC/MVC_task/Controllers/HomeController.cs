using Microsoft.AspNetCore.Mvc;
using MVC_task.Models;
using System.Diagnostics;

namespace MVC_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Profile(RegistrationModel model)
        {
            if (model.Name != null && model.Surname != null)
            {
                _logger.LogInformation(model.Name);
                _logger.LogInformation(model.Surname);
                _logger.LogInformation(model.Sex);
            }

            return View();
        }
    }
}
