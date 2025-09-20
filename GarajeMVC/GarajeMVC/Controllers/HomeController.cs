using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        private static Garage miGaraje = new Garage(1, "Bryan Hernandez", 10, 0);

        public IActionResult Index()
        {
            if (miGaraje.GetAutos().Count == 0)
            {
                miGaraje.IngresarAuto(new Auto(1, "Maserati", "HAG 2511"));
                miGaraje.IngresarAuto(new Auto(2, "Suzuki", "HAZ 4564"));
                miGaraje.IngresarAuto(new Auto(3, "Aston Martin", "HAW 45455"));
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