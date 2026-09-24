using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IFinancas.Models;
using Microsoft.AspNetCore.Authorization;

namespace IFinancas.Controllers;

[Authorize]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [AllowAnonymous]
    public IActionResult Privacy()
    {
        return View();
    }

}
