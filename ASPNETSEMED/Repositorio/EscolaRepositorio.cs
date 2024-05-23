using TesteMVC.Data;
using TesteMVC.Models;

namespace TesteMVC.Repositorio
{
    public class EscolaRepositorio : IEscolaRepositorio
    {
        private readonly BancoContext _context;

        public EscolaRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }
        public EscolaModel Atualizar(EscolaModel model)
        {
            if(model.Escola != null)
            {

                EscolaModel escolaDB = ListarPorId(model.Escola);

                

                escolaDB.Id = model.Id;
                escolaDB.Escola = model.Escola;
                escolaDB.Cnpj = model.Cnpj;
                escolaDB.Telefone = model.Telefone;
                escolaDB.Diretor = model.Telefone;
                escolaDB.Email = model.Telefone;
                escolaDB.Status = model.Telefone;


                _context.Escola.Update(escolaDB);
                _context.SaveChanges();

                return escolaDB; 
            }
            
            throw new System.Exception("Erro na alteração, id está vazio");
        }

        public List<EscolaModel> ListaEscola()
        {
            return _context.Escola.ToList();
        }

        public EscolaModel ListarPorId(string nome)
        {
             if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O ID não pode ser nulo ou vazio", nameof(nome));
            }

            var item = _context.Escola.FirstOrDefault(x => x.Escola == nome) ?? throw new Exception($"Nenhum registro encontrado com o ID {nome}");
            return item;
        }

    }
}