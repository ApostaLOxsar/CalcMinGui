using System.Text.RegularExpressions;
using TestDBWithEFCore.DB;
using TestDBWithEFCore.DB.Tabels;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new ApplicationContext())
        {

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            //context.Peoples.Add(people);
            //context.Add(book);
            //context.SaveChanges();


            var result = from p in context.Peoples
                         join b in context.Books
                         on p.Id equals b.people.Id
                         select new { p.Id, p.Name, p.Age, b.Title, BookId = b.Id };
          


            /*People peopleNew = Logic.CreatePeople();
            if (peopleNew != null)
            {
                context.Add(peopleNew);
                Console.WriteLine(peopleNew.Name + " <-- Добавлен");
            }
            context.SaveChanges();*/


            /*
            Logic.PrintResalt(context.Peoples);
            Console.Write("\n --> ");


            Book book = new Book()
            {
                people = context.Peoples.Find(1),
                Title = "this is title for book for people with id = 1"
            };
            */

            Logic.PrintResalt(result);

            //context.SaveChanges();


            /*
            foreach(var item in context.Peoples.ToList())
            {
                Console.WriteLine(item);
            }

            foreach (var item in context.Books.ToList())
            {
                Console.WriteLine(item.ToString() + "   " + item.people.Id);
            }*/
        }
    }
}