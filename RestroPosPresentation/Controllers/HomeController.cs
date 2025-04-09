using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PosService;
using RestroPosPresentation.Models;

namespace RestroPosPresentation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FoodService _foodService;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _foodService = new FoodService();
    }

    public IActionResult Index()
    {
        ViewBag.FoodItems = _foodService.GetFoodItems();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
