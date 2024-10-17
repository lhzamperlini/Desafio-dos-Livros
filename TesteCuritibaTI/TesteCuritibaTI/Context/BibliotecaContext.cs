using Microsoft.EntityFrameworkCore;
using TesteCuritibaTI.Models;

namespace TesteCuritibaTI.Context;

public class BibliotecaContext : DbContext
{
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
    {
    }

    public DbSet<Livro> Livros { get; set; }
}
