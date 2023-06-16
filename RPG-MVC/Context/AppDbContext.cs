using Microsoft.EntityFrameworkCore;
using RPG_MVC.Models;

namespace RPG_MVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Jogador>? Jogadores { get; set; }
        public DbSet<Arma>? Armas { get; set; }
        public DbSet<Inimigo>? Inimigos { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {optionsBuilder.UseSqlite("Data Source=banco.db;Cache=Shared");}
    }
}
