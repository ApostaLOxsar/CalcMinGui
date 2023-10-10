using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using TestDateBase.DB;
using TestDateBase.DB.Tabels;

namespace TestDateBase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("1 - печать");
            Console.WriteLine("2 - добавить");
            Console.WriteLine("3 - удалить");
            Console.WriteLine("4 - выход");*/

            //bool flag = true;

            //int inputNumber = Logics.InputInt();

            //Console.WriteLine(inputNumber);

            using (var context = new MyDbContext())
            {
                People people = new People()
                {
                    Name = "Fofgafo",
                    Age = 142
                };

                /*Book book = new Book()
                {
                    people = people,
                    Title = "Bgsdfgr"
                };*/


                var res = from peoples in context.Peoples
                          join book in context.Books on peoples.Id equals book.people.Id
                          orderby peoples.Id
                          select new
                          {
                              peoples.Id,
                              peoples.Name,
                              peoples.Age,
                              book.Title,
                              BookId = book.Id,
                          };


                foreach (var result in res)
                {
                    Console.WriteLine($"Id: {result.Id} \t Book: {result.BookId} \t Name {result.Name}" +
                        $" \t Age: {result.Age} \t Title: {result.Title}");
                    
                }
                //SELECT * FROM Books JOIN People ON People.Id = Books.people_Id

                /*context.Peoples.Add(people);
                context.Books.Add(book);
                context.SaveChanges();*/
                //Console.WriteLine($"id : {people.Id}, Name: {people.Name}, Age: {people.Age}");
                Console.ReadKey();
            }

        }
    }
}