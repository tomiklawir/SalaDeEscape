using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalaDeEscape.Models;

namespace SalaDeEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        return View("tutorial");
    }
    public IActionResult creditos()
    {
        return View("creditos");
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala == Escape.GetEstadoJuego() && Escape.ResolverSala(sala, clave)){
            if (sala == 4)
            {
                return View("Victoria");
            }
            else
            {
                return View("Habitacion" + (sala+1));
            }
        }
        else 
        {
            ViewBag.Error = "Error";
            return View("Habitacion" + sala);
        }
    }
    
    public IActionResult Comenzar()
    {
        return View("Oficina");
    }
    public IActionResult bovedaoscura()
    {
        return View("bovedaoscura");
    }
    public IActionResult boveda()
    {
        return View("boveda");
    }
    public IActionResult afueraboveda()
    {
        return View("afueraboveda");
    }
}