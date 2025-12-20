using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AstraArchive.Models;

namespace AstraArchive.Controllers;

public class SignupController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Signup()
    {
        return null;
    }
}
