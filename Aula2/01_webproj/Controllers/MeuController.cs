using Microsoft.AspNetCore.Mvc;
using _01_webproj.Models;

public class MeuController : Controller
{
    public void Acao01(){
        Console.WriteLine("Mensagem vinda do controlador"+ this.GetType().Name);
    }
    public string Acao02(){
        return "Euuu ação 2";
    }

    public int Acao03(){
        return 47;
    }
public ErrorViewModel Acao04(){
    return new ErrorViewModel(){ RequestId = "Teste de erro" };
}

public IActionResult Acao05(int? id){
    switch(id){
        case 200: return Accepted();
        case 404: return NotFound();
        default:  return NoContent();
    }
}
}