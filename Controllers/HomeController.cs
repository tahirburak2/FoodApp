using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FoodApp.Models;

namespace FoodApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    }
