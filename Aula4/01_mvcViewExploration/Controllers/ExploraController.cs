using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace _01_mvcViewExploration.Controllers;

public class ExploraController : Controller
{
    public IActionResult Principal(){
        ViewData["nome"] = "Iara Lima";
        ViewData["titulo"] = "projeto inicial";
        ViewData["outra"] = "785.52";
        ViewBag.umExemplo = true; 
        //chamada da view
        return View("Index");
    }
}