using System.Collections.Concurrent;
using _01_mvcViewExploration.Models;

namespace _01_mvcViewExploration.Services;

public class CEPLocalStorage : ICEPServices
{

    private ConcurrentDictionary<int,CEPModel> localStorageInMemory;

    public CEPLocalStorage(){
        localStorageInMemory = new();

        localStorageInMemory.TryAdd(99999, new CEPModel(){CEP=99999, Estado="RS", Cidade="POA", Bairro="Centro", Logradouro="Rua"});
        localStorageInMemory.TryAdd(90840450, new CEPModel(){CEP=90840450, Estado="RS", Cidade="Porto Alegres", Bairro="Santa Tereza", Logradouro="Alvaro Osimo Caetano"});
        localStorageInMemory.TryAdd(90850130, new CEPModel(){CEP=90850130, Estado="RS", Cidade="Porto Alegres", Bairro="Menino Deus", Logradouro="Dona Augusta"});
        localStorageInMemory.TryAdd(90690000, new CEPModel(){CEP=90690000, Estado="RS", Cidade="Porto Alegres", Bairro="Partenon", Logradouro="Ipiranga"});
        localStorageInMemory.TryAdd(92110001, new CEPModel(){CEP=92110001, Cidade="Canoas", Estado="RS", Bairro="Niteroi", Logradouro="Venancio Aires"});
    }
    public CEPModel? CadastrarCEP(CEPModel CEP)
    {
       localStorageInMemory.TryAdd(CEP.CEP,CEP);
       return CEP;
    }

    public IEnumerable<CEPModel> listaCEPs()
    {
       return localStorageInMemory.Values;
    }

    public CEPModel? pesquisaCEP(int CEP)
    {
        throw new NotImplementedException();
    }
}