namespace _01_mvcViewExploration.Models;

public class CEPModel
{
    public int CEP { get; set; }

    public string Cidade {get; set;}=null!;
    public string Estado {get; set;}=null!;
    public string  Logradouro {get; set;}=null!;
    public string Bairro {get; set;}=null!;
}
