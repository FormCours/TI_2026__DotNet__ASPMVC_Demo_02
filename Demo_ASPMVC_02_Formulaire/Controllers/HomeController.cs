using Demo_ASPMVC_02_Formulaire.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_ASPMVC_02_Formulaire.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Action pour le verbe « GET »
            return View();
        }

        /*
        [HttpPost]
        public IActionResult Index(string name, string email, int number)
        {
            // Action pour le verbe « POST »
            return View();
        }
        */

        [HttpPost]
        public IActionResult Index(RegistrationForm data)
        {
            // Action pour le verbe « POST »
            if(!ModelState.IsValid)
            {
                // Renvoi du formulaire avec les données partiels et les messages d'erreurs

                return View(data);
            }

            // Redirection / Ré-afficher une page
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
