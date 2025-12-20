using Microsoft.AspNetCore.Mvc;
using AstraArchive.Models;

namespace AstraArchive.Controllers;

public class SigninController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Signin(SigninViewModel model)
    {
        if(!ModelState.IsValid) 
        {
            return View("Index", model);
        }

        // TODO logic
        if(model.Username == "lkelly" && model.Password == "lkelly")
        {
            return RedirectToAction("Index", "Explore");
        }
        else
        {
            ModelState.AddModelError(nameof(model.Username), "");
            ModelState.AddModelError(nameof(model.Password), "");
            return View("Index", model);
        }
    }
}
