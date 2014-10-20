using System;
using TSimulator.Helpers;

namespace TSimulator
{
    class Simulator
    {
        static void Main(string[] args)
        {
            try
            {
                var filenames = new Filenames();
                filenames.Initialize(args);

                OutputHelper.SetUpDefaults();

                var streamStates = StreamStates.InitializeStreamStates(filenames);
                //note control input watcher is on main thread, while other watchers are on separate threads
                streamStates.StartWatching();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred, with the following details: "+e.Message);
            }
        }

    }
}
