using System;
using System.Collections.Generic;
using System.Text;

namespace firstcode.helloworld
{
    class helloworld 

    {

        static void Main(string[] args)
        {

            Console.Write("what is your name\n");
            string name = Console.ReadLine();

            Console.Write("my name is" + name);

            Console.ReadKey();
        }


    }
}
