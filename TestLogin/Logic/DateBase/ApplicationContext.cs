using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestLogin.Logic.DateBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }

        public ApplicationContext() : base("DateBase") {  }



    }
}
