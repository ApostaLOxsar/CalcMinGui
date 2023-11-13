

namespace TestDBWithEFCore.DB.Tabels
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
