using System.Text.RegularExpressions;
using TestDBWithEFCore.DB;
using TestDBWithEFCore.DB.Tabels;

using (var context = new ApplicationContext())
{
    People people = new People()
    {
        Name = "this is name for people",
        Age = 142
    };

    Book book = new Book()
    {
        people = people,
        Title = "this is title for book"
    };


    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
    context.Peoples.Add(people);
    context.Add(book);
    context.SaveChanges();


    var result = from p in context.Peoples
                 join b in context.Books
                 on p.Id equals b.people.Id
                 select new {p.Id, p.Name, p.Age, b.Title, BookId = b.Id };

    Console.WriteLine(Logic.CreatePeople() != null ? Logic.CreatePeople():"People not create");
    
    //Logic.PrintResalt(result);


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
