using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMST5_MVC_Login.Models;

namespace AMST5_MVC_Login.Controllers;

public class Authentication : Controller
{
    private readonly ILogger<Authentication> _logger;

    public Authentication(ILogger<Authentication> logger)
    {
        _logger = logger;
    }
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult ForgotPassword()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

