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
            var lang = args.Length > 0 ? args[0] : "en";

            switch (lang)
            {
                case "fr":
                    Console.WriteLine("Bonjour le monde!");
                    break;
                default:
                    Console.WriteLine("Hello world!");
                    break;
            }

            // wait that user press a key before exit.
            Console.ReadKey(true);
        }
    }
}
