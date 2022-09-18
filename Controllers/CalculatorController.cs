using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LP3_ASPNET_Refactor.Models;

namespace LP3_ASPNET_Refactor.Controllers;

public class CalculatorController : Controller
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    public IActionResult CalculatorOperation()
    {
        return View();
    }

    public IActionResult CalculatorOperationResult([FromForm] OperationRequest operation)
    {
        return View(operation);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
