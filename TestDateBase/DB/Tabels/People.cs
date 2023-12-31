﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TestDateBase.DB.Tabels
{

    public class People
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return "Id: " + Id.ToString() + " Name: " + Name + (Age == null ? "" : (" Age: " + Age.ToString()));
        }
    }

}
