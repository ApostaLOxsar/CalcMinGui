using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestDBWithEFCore.DB.Tabels;

namespace TestDBWithEFCore.DB
{
    public static class Logic
    {
        public static void PrintResalt(IQueryable inp)
        {
            string res;

            foreach (var item in inp)
            {
                //res = item.ToString().Replace("{", "--> ").Replace("}", "<--").Replace(",", " |");
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        public static People CreatePeople()
        {
            Console.Write("Name: ");
            string? Name;
            int Age;

            //input name
            try
            {
                Name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Name))
                {
                    throw new Exception("Пустая строка");
                }
            }
            catch
            {
                return null;
            }



            //input age
            try
            {
                Console.Write("Age: ");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                return new People()
                {
                    Name = Name
                };
            }




            return new People()
            {
                Name = Name,
                Age = Age

            };
        }
    

    }



}
