using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.Logic.DateBase
{
    public class Ryles_Login
    {
        private int id_ryles { get; set; }
        private int id_login { get; set; }

        public Ryles_Login() { }
        public Ryles_Login(int id_ryles, int id_login)
        {
            this.id_ryles = id_ryles;
            this.id_login = id_login;
        }
    }
}
