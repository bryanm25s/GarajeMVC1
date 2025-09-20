using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        private static Garage miGaraje = new Garage(1, "Tu Nombre Completo Aquí", 10, 0);

        public IActionResult Index()
        {
            if (miGaraje.GetAutos().Count == 0)
            {
                miGaraje.IngresarAuto(new Auto(1, "Toyota", "HAG 3034"));
                miGaraje.IngresarAuto(new Auto(2, "Ford", "HAZ 8990"));
                miGaraje.IngresarAuto(new Auto(3, "Hyundai", "ZAW 2019"));
            }
            return View(miGaraje);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}