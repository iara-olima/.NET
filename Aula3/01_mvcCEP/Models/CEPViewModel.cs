using System.ComponentModel.DataAnnotations;
namespace _01_mvcCEP.Models;
public class CEPViewModel
{
    [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter 8 dígitos!")] //Expressao regular que determina se o valor de entrada é valido
    public string CEP{ get; set; }=null!;
    [RegularExpression(@"^[A-Z]{2}$", ErrorMessage ="A UF deve conter só 2 caracteres")]
    public string UF{ get; set; }=null!;
    [StringLength(50,MinimumLength =3, ErrorMessage = "O nome da cidade deve conter entre 3 e 50 caracteres")]
    public string Cidade{ get; set; }=null!;
    [StringLength(20)]
    public string Bairro{ get; set; }=null!;
    [StringLength(100)]
    public string Logradouro{ get; set; }=null!;
}