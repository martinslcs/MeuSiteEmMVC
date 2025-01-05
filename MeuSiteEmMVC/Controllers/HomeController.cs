using System.Diagnostics;
using MeuSiteEmMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuSiteEmMVC.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Lucas Martins";

            home.Email = "martinslucasds@hotmail.com";

            return View(home);
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
