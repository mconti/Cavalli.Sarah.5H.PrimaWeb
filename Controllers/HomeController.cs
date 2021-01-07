using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cavalli.Sarah._5H.PrimaWeb.Models;

namespace Cavalli.Sarah._5H.PrimaWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Prenota()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Prenota(Prenotazione p)
        {
            var db = new PrenotazioneContext();
            db.Prenotazioni.Add(p);
            db.SaveChanges();

            return View("Grazie" , db.Prenotazioni.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
