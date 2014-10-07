using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSimulator
{
    static class Filenames
    {
        public static string History { get; set; }
        public static string ControlInput { get; set; }
        public static string ControlOutput { get; set; }
        public static string[] Streams { get; set; }

        public static void Initialize()
        {
            Filenames.Streams = new string[4];
        }
    }
}
