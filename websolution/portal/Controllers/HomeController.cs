using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portal.Models;

namespace portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Person prn1=new Person{Id=10, Fname="Vishal", Lname="Karale"};
        Person prn2=new Person{Id=20,Fname="Sachin", Lname="Ombale"};
        Person prn3=new Person{Id=30,Fname="Sachin", Lname="Chitale"};
        List<Person> family =new List<Person>();
        family.Add(prn1);
        family.Add(prn2);
        family.Add(prn3);
        this.ViewData["Family"]=family;
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
