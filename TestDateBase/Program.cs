using System;
using TestDateBase;
using TestDateBase.DB;
using TestDateBase.DB.Tabels;

namespace TestDateBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - печать");
            Console.WriteLine("2 - добавить");
            Console.WriteLine("3 - удалить");
            Console.WriteLine("4 - выход");

            //bool flag = true;

            //int inputNumber = Logics.InputInt();

            //Console.WriteLine(inputNumber);

            using (var context = new MyDbContext())
            {
                People people = new People()
                {
                    Name = "Foo",
                    Age = 12
                };

                context.Entry(people);


                context.Peoples.Add(people);
                context.SaveChanges();

                Console.WriteLine($"id : {people.Id}, Name: {people.Name}, Age: {people.Age}");
                Console.ReadKey();
            }
        }
    }
}