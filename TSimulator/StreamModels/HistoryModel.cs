using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSimulator.StreamModels
{
    internal class HistoryModel
    {
        /// <summary>
        /// The backing structure of all the bids made the previous day
        /// </summary>
        public List<int> Bids { get; set; }
        public int BidCount { get { return Bids.Count; }}
        public HistoryModel()
        {
            Bids = new List<int>();
        }
    }
}
