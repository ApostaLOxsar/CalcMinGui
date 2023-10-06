using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.Logic.DateBase
{
    public class Ryle
    {
        private int id_ryles { get; set; }
        private string ryle { get; set; }

        public Ryle() { }

        public Ryle(int id_ryles, string ryle)
        {
            this.id_ryles = id_ryles;
            this.ryle = ryle;
        }
    }
}
