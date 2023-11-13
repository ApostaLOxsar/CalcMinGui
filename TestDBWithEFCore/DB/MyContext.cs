using Microsoft.EntityFrameworkCore;
using TestDBWithEFCore.DB.Tabels;

namespace TestDBWithEFCore.DB
{
    internal class MyContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>().Property(b => b.Id);
            modelBuilder.Entity<Book>().Property(b => b.Id);
        }
    }
}
