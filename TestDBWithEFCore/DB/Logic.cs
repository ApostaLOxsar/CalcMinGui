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
                res = item.ToString().Replace("{", "--> ").Replace("}", "<--").Replace(",", " |");
                Console.WriteLine(res);
            }

            Console.WriteLine();
        }
        public static People CreatePeople()
        {
            Console.Write("Name: ");
            string Name;
            int Age;
            try
            {
                Name = Console.ReadLine();
                if (Name.Length == 0 ) {
                    throw new Exception("Пустая строка");
                }
            }
            catch
            {
                return null;
            }

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
