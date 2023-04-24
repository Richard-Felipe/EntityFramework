using Microsoft.EntityFrameworkCore;

namespace Loja.Data;
public class LojaContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=127.0.0.1;Database=Loja;User Id=sa;Password=Dev$123;Encrypt=False;");
    }
}