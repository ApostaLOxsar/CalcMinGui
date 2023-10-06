using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDateBase
{
    public static class Logics
    {

        public static int InputInt()
        {
            bool flag = false;
            int inputInt = -1;
            while (!flag)
            {
                Console.WriteLine("введите число 1 - 4");
                string inputStr = Console.ReadLine();

                try
                {
                    inputInt = Int32.Parse(inputStr);
                    if (1 <= inputInt && inputInt <= 4)
                    {
                        flag = true;
                        return inputInt;
                    }
                }
                catch
                { }
                Console.WriteLine("не подходит");


            }

            return inputInt;
        }


    }
}
