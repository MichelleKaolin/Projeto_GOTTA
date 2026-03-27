using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Gotta.Models;

namespace Gotta.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult SobreNos()
    {
        return View();
    }
     public IActionResult Inscricao()
    {
        return View();
    }
public IActionResult Contato()
    {
        return View();
    }
    public IActionResult Funcionamento()
    {
        return View();
    }
public IActionResult Mapa()
    {
        return View();
    }

    public IActionResult Index()
    {
        return RedirectToAction("SobreNos"); 
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
