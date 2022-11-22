using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNetflix
{
    internal class TvShow : ISeries
    {
        public string Title { get; set; }
        public List<string> Actors { get; set; }
        public double Duration { get; set; }
        public string Genre { get; set; }
        public bool LikedOrNot { get; set; }
        public int Seasons { get; set; }
        public int EpisodesPerSeason { get; set; }
        public double DurationOfShow { get; private set; }

        public TvShow(string title, double duration, string genre, int seasons, int episodesPerSeason)
        {
            Title = title;
            Actors = new List<string>();
            Duration = duration;
            Genre = genre;
            Seasons = seasons;
            EpisodesPerSeason = episodesPerSeason;
            
        }

        public void Liked()
        {
            LikedOrNot = true;
        }

        public void SetTotalDuration()
        {
           DurationOfShow = Seasons * EpisodesPerSeason * Duration;
        }

        public void AddActors(string[] actors)
        {
            foreach (var actor in actors)
            {
                Actors.Add(actor);
            };
        }
    }
}
