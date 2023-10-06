using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.Logic.DateBase
{
    public class Information
    {
        private int id_inf { get; set; }
        private int id_login { get; set; }
        private string name { get; set; }
        private string tabels_number { get; set; }

        public Information() { }

        public Information(int id_inf, int id_login, string name, string tabels_number)
        {
            this.id_inf = id_inf;
            this.id_login = id_login;
            this.name = name;
            this.tabels_number = tabels_number;
        }
    }
}
