using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TSimulator
{
    class Simulator
    {
        static void Main(string[] args)
        {
            var filenames = new Filenames();
            filenames.Initialize(args);

            var streamStates = StreamStates.InitializeStreamStates(filenames);
            streamStates.StartWatching();

            System.Threading.Thread.Sleep(5000000);
            return;
        }

    }
}
