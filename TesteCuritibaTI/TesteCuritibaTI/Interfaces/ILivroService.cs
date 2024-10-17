using TesteCuritibaTI.Models;

namespace TesteCuritibaTI.Interfaces;

public interface ILivroService
{
    Task<List<Livro>> ObterLista();
    Task<bool> Cadastrar(Livro livro);
}
