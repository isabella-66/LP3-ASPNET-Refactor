using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LP3_ASPNET_Refactor.Models;

namespace LP3_ASPNET_Refactor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult FirstAction() 
    {
        return View();
    }

    public string QueryTest([FromQuery] string cor, [FromQuery] string valor) 
    {
        return $"Chegou aqui {cor} e {valor}";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
