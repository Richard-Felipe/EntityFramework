using Loja.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja.Data;
public class LojaContext : DbContext
{
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Compra> Compra { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=127.0.0.1;Database=Loja;User Id=sa;Password=Dev$123;Encrypt=False;");
    }
}