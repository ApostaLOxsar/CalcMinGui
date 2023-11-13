using System;
using System.Data.Entity;
using System.Reflection.Emit;
using TestDateBase.DB.Tabels;

namespace TestDateBase.DB
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DateBase") { }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
