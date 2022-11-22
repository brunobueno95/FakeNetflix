using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNetflix
{
    internal interface ISeries : IContent
    {

        int Seasons { get; set; }
        int EpisodesPerSeason { get; set; }
       double DurationOfShow { get; }  // total duration of entire show

        void SetTotalDuration();
        
    }
}
