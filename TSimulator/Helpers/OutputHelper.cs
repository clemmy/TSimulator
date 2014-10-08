using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSimulator.Helpers
{
    static class OutputHelper
    {
        static void SetUpDefaults()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void WriteInBlue(string text)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void WriteInRed(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
