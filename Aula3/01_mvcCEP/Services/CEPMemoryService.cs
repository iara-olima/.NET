using _01_mvcCEP.Models;
using System.Collections.Concurrent;
namespace _01_mvcCEP.Services;
public class CEPMemoryService: ICEPServices
{
    private readonly ConcurrentDictionary<string, CEPViewModel> listaDeCEPs = new ConcurrentDictionary<string, CEPViewModel>(); 

    IEnumerable<CEPViewModel> ICEPServices.listaCEPs()
    {
        return listaDeCEPs.Values;
    }

    void ICEPServices.cadastraCEPs(CEPViewModel p)
    {
        listaDeCEPs.TryAdd(p.CEP,p);
    }

    CEPViewModel? ICEPServices.buscaCEPs(string cep)
    {
        CEPViewModel? searchResult;
        listaDeCEPs.TryGetValue(cep, out searchResult);
        return searchResult;
    }

    public CEPMemoryService(){
        CEPViewModel aux = new CEPViewModel{
                CEP = "90619900",
                Bairro="Parteon",
                Cidade="Porto Alegre",
                UF="RS",
                Logradouro="AV. Ipiranga 6681"
            };
        listaDeCEPs.TryAdd(aux.CEP, aux);

        aux = new CEPViewModel{
            CEP = "92704355",
                Bairro="Centro",
                Cidade="Guaíba",
                UF="RS",
                Logradouro="Vinte de Setembro 1445"
        };
         listaDeCEPs.TryAdd(aux.CEP, aux);

          aux = new CEPViewModel{
            CEP = "49302945",
                Bairro="Bairro x",
                Cidade="Cidade x",
                UF="RS",
                Logradouro="Rua x 0000"
        };
         listaDeCEPs.TryAdd(aux.CEP, aux);
    }
}