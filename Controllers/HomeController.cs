using Evaluacion1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Evaluacion1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "¡Bienvenido al Aeropuerto Regional!";
            return View();
        }
    }

}
