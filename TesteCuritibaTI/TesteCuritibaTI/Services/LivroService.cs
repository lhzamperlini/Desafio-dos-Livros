using Microsoft.EntityFrameworkCore;
using TesteCuritibaTI.Context;
using TesteCuritibaTI.Interfaces;
using TesteCuritibaTI.Models;

namespace TesteCuritibaTI.Services;

public class LivroService : ILivroService
{
    private readonly BibliotecaContext _context;

    public LivroService(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<List<Livro>> ObterLista()
    {
        return await _context.Livros.ToListAsync();
    }

    public async Task<bool> Cadastrar(Livro livro)
    {
        try
        {
            _context.Add(livro);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }

    }

}
