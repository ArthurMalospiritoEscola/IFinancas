using Microsoft.EntityFrameworkCore;
using IFinancas.Models;

namespace IFinancas.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Conta> Contas { get; set; }
    public DbSet<Lancamento> Lancamentos { get; set; }
}