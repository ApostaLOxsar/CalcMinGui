using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.Logic.DateBase
{
    public class Login
    {
        
       // private int id_login { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        [Key]
        public int id_login { get; set; }

        public Login() { }

        public Login(/*int id_login*/ string login, string password)
        {
            /*this.id_login = id_login;*/
            this.login = login;
            this.password = password;
        }

        public string GetLogin => this.login;

    }
}
