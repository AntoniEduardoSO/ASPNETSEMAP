using TesteMVC.Models;

namespace TesteMVC.Repositorio
{
    public interface IEscolaRepositorio
    {
        
        EscolaModel ListarPorId(string id);
        List<EscolaModel> ListaEscola();

        EscolaModel Atualizar(EscolaModel model);

    }
}