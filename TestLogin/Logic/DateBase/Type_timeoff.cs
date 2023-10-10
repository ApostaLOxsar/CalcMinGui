using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.Logic.DateBase
{
    class Type_timeoff
    {
        [Key]
        private int id_timeoff { get; set; }
        private string type { get; set; }

        public Type_timeoff() { }
        public Type_timeoff(int id_timeoff, string type)
        {
            this.id_timeoff = id_timeoff;
            this.type = type;
        }
    }
}
