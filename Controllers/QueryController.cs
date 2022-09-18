using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LP3_ASPNET_Refactor.Models;

namespace EstudoASPNET.Controllers;

public class QueryController : Controller
{
    private readonly ILogger<QueryController> _logger;

    public QueryController(ILogger<QueryController> logger)
    {
        _logger = logger;
    }

    public string QueryStringTest([FromQuery] string q, [FromQuery] string nome) 
    {
        return $"Chegou aqui {q} e {nome}";
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}