using System;
using System.Collections.Generic;
using System.Text;

namespace secondcode.secondcode
{
    class Datatype
    {
        public static void Main()

        {

            Console.Write("please inpute first number");


            int x = Convert.ToInt32(Console.ReadLine());


            Console.Write("please inpute second number");


            int y = Convert.ToInt32(Console.ReadLine());

            int z = x + y;

            Console.Write("the result is" + z);

            Console.ReadKey();
        }

    }
}
