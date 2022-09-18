using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LP3_ASPNET_Refactor.Models;

namespace LP3_ASPNET_Refactor.Controllers;

public class MathOperationsController : Controller
{
    private readonly ILogger<MathOperationsController> _logger;

    public MathOperationsController(ILogger<MathOperationsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Sum()
    {
        return View();
    }

    public IActionResult SumOperation([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewBag.NumberOne = numberOne;
        ViewBag.NumberTwo = numberTwo;
        ViewBag.Result = numberOne + numberTwo;
        return View();
    }

    public IActionResult Sub()
    {
        return View();
    }

    public IActionResult SubOperation([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewBag.NumberOne = numberOne;
        ViewBag.NumberTwo = numberTwo;
        ViewBag.Result = numberOne - numberTwo;
        return View();
    }

    public IActionResult Div()
    {
        return View();
    }

    public IActionResult DivOperation([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewBag.NumberOne = numberOne;
        ViewBag.NumberTwo = numberTwo;
        ViewBag.Result = numberOne / numberTwo;
        return View();
    }

    public IActionResult Mult()
    {
        return View();
    }

    public IActionResult MultOperation([FromForm] double numberOne, [FromForm] double numberTwo)
    {
        ViewBag.NumberOne = numberOne;
        ViewBag.NumberTwo = numberTwo;
        ViewBag.Result = numberOne * numberTwo;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}