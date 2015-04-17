using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "fr":
                    Console.WriteLine("Bonjour le monde!");
                    break;
                default:
                    Console.WriteLine("hello world!");
                    break;
            }

            // wait that user press a key before exit.
            Console.ReadKey(true);
        }
    }
}
