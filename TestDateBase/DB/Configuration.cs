using System;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Data.SQLite.EF6.Migrations;

namespace TestDateBase.DB
{


    internal sealed class Configuration : DbMigrationsConfiguration<MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());

        }

         protected override void Seed(MyDbContext context)
        {
           
        }
    }
}
