using Examen.Application.UseCases;
using Examen.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Examen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProcesoServices _procesoServices;

        public HomeController(ILogger<HomeController> logger, IProcesoServices procesoServices)
        {
            _logger = logger;
            _procesoServices = procesoServices;
        }

        public IActionResult Index()
        {
            var result = _procesoServices.GetAll();
            return View();
        }

    }
}
