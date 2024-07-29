using CadastroPessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoas.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Pessoa> Pessoas { get; set; } = null!;
}
