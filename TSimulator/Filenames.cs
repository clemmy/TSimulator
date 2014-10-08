using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSimulator
{
    class Filenames
    {
        public string History { get; set; }
        public string ControlInput { get; set; }
        public string ControlOutput { get; set; }
        public string[] Streams { get; set; }

        /// <summary>
        /// Initializes the static filename properties to their corresponding filenames based on the program parameters.
        /// </summary>
        /// <param name="args"></param>
        public void Initialize(string[] args)
        {
            Streams = new string[4];

            foreach (string path in args)
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException();
                }
            }

            History = args[0];
            ControlInput = args[1];
            ControlOutput = args[2];
            Streams[0] = args[3];
            Streams[1] = args[4];
            Streams[2] = args[5];
            Streams[3] = args[6];
        }
    }
}
