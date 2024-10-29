using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _01_mvcViewExploration.Models;
using _01_mvcViewExploration.Services;

namespace _01_mvcViewExploration.Controllers;

public class CEPController: Controller
{
    private readonly ICEPServices CEPServices;

    public CEPController(ICEPServices Service){
        CEPServices = Service;
    }

public IActionResult Index(){
    IEnumerable<CEPModel> list = CEPServices.listaCEPs();
    return View("ListaCEPobj",list);
}

public IActionResult Cadastra(){
   return View();
}

[HttpPost]
public IActionResult Cadastra(CEPModel Cepp){
     if(ModelState.IsValid)
        CEPServices.CadastrarCEP(Cepp);

        return View("ListaCEPObj", CEPServices.listaCEPs());
}

}