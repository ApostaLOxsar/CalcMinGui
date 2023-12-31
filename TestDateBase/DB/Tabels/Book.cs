﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDateBase.DB.Tabels
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public People people { get; set; }

        public override string ToString()
        {
            return "Id: " + Id.ToString() + " Title: " + Title;
        }
    }
}
