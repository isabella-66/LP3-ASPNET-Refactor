using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LP3_ASPNET_Refactor.Models;

namespace LP3_ASPNET_Refactor.Controllers;

public class FormularyController : Controller
{
    private readonly ILogger<FormularyController> _logger;

    public FormularyController(ILogger<FormularyController> logger)
    {
        _logger = logger;
    }

    public IActionResult Form() 
    {
        return View();
    }

    public string FormData([FromForm] UserRequest userRequest) 
    {
        return $"Nome: {userRequest.Name}, E-mail: {userRequest.Email}, Senha: {userRequest.Password}";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}