using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSimulator.StreamModels;

namespace TSimulator
{
    class StreamStates
    {
        public HistoryModel HistoryStream { get; set; }
        public ControlInputModel ControlInputStream { get; set; }
        public ControlOutputModel ControlOutputStream { get; set; }
        public BidStreamModel[] BidStramModels { get; set; }

        public static StreamStates GetStreamStates()
        {
            var s = new StreamStates()
            {
                BidStramModels = new BidStreamModel[4]
            };
           
            return s;
        }

        private StreamStates()
        {
            
        }
    }
}
