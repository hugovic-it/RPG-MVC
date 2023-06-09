using Microsoft.EntityFrameworkCore;

namespace RPG_MVC.Context
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=banco.db;Cache=Shared");
        }
    }
}
