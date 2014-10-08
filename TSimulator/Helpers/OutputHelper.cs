using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSimulator.Helpers
{
    static class OutputHelper
    {
        public static void SetUpDefaults()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Writes to the console in blue 
        /// Generally used for output
        /// </summary>
        /// <param name="text"></param>
        public static void WriteInBlue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Writes to the console in red
        /// Generally used for input
        /// </summary>
        /// <param name="text"></param>
        public static void WriteInRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
