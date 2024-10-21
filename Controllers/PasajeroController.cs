using Evaluacion1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evaluacion1.Controllers
{
    public class PasajeroController : Controller
    {
        private static List<Pasajero> _pasajeros = new List<Pasajero>();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pasajero pasajero)
        {
            if (ModelState.IsValid)
            {
                _pasajeros.Add(pasajero);
                return RedirectToAction("List");
            }
            return View(pasajero);
        }

        public IActionResult List()
        {
            return View(_pasajeros);
        }

        public IActionResult Delete(int identificacion)
        {
            var pasajero = _pasajeros.FirstOrDefault(p => p.Identificacion == identificacion);
            if (pasajero != null)
            {
                _pasajeros.Remove(pasajero);
            }
            return RedirectToAction("List");
        }
    }

}
