using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TesteMVC.Models;

namespace TesteMVC.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        HomeModel home = new()
        {
            Nome = "Antonio Eduardo",
            Email = "antoniooliveira@semed.maceio.al.gov.br"
        };


        return View(home);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
