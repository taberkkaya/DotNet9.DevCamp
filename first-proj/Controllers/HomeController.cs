using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using first_proj.Models;

namespace first_proj.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View(Repository.Courses);
    }
    public IActionResult Contact()
    {
        return View();
    }
}
