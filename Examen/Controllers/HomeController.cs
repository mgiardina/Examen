using Examen.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Examen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationServices _procesoServices;

        public HomeController(ILogger<HomeController> logger, IApplicationServices procesoServices)
        {
            _logger = logger;
            _procesoServices = procesoServices;
        }

        public IActionResult Index()
        {
            var result = _procesoServices.GetAll();
            return View(result);
        }

    }
}
