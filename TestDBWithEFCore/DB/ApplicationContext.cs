using Microsoft.EntityFrameworkCore;
using TestDBWithEFCore.DB.Tabels;

namespace TestDBWithEFCore.DB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<People> Peoples => Set<People>();
        public DbSet<Book> Books => Set<Book>();
        public ApplicationContext() => Database.EnsureCreated();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\DateBase.db");
        }
    }
}
