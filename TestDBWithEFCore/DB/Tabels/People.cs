
using Microsoft.EntityFrameworkCore;

namespace TestDBWithEFCore.DB.Tabels
{
    public class People
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return "Id: " + Id.ToString() + " Name: " + Name + (Age == null ? "" : (" Age: " + Age.ToString()));
        }
    }

}
