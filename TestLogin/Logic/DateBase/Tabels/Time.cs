using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.Logic.DateBase
{
    public class Time
    {
        [Key]
        public int id_time { get; set; }
        public int id_login { get; set; }
        public int id_timeoff { get; set; }

        public DateTime in_time { get; set; }
        public DateTime out_time { get; set; }
        public DateTime timeoff { get; set; }

        public Time() { }
        public Time(int id_time, int id_login, int id_timeoff, DateTime in_time, DateTime out_time, DateTime timeoff)
        {
            this.id_time = id_time;
            this.id_login = id_login;
            this.id_timeoff = id_timeoff;
            this.in_time = in_time;
            this.out_time = out_time;
            this.timeoff = timeoff;
        }
    }
}
