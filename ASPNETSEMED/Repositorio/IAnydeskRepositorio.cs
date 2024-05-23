using TesteMVC.Models;

namespace TesteMVC.Repositorio
{
    public interface IAnydeskRepositorio
    {
        
        AnydeskModel ListarPorId(string id);
        List<AnydeskModel> ListaAnydesk();
        AnydeskModel Adicionar(AnydeskModel model);

        AnydeskModel Atualizar(AnydeskModel model);


        bool Apagar(string id);

        


    }
}