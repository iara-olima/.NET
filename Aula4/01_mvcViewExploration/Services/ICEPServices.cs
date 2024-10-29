using _01_mvcViewExploration.Models;
namespace _01_mvcViewExploration.Services;
public interface ICEPServices{
    IEnumerable<CEPModel>listaCEPs();
   CEPModel? CadastrarCEP(CEPModel CEP);
    CEPModel? pesquisaCEP(int CEP);
}