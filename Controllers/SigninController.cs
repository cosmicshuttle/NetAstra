using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AstraArchive.Models;

namespace AstraArchive.Controllers;

public class SigninController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
