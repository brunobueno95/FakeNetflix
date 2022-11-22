using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNetflix
{
    internal class Movie : IContent
    {
        public string Title {get;set;}
        public List<string> Actors {get;set;}
        public double Duration {get;set;}
        public string Genre { get; set;}
        public bool LikedOrNot {get; set;}
      

        public Movie(string title, double duration, string genre, bool likedOrNot)
        {
            Title = title;
            
            Duration = duration;
            Genre = genre;
            Actors = new List<string>();
            
        }

        public void Liked()
        {
            LikedOrNot = true;
        }

        public void AddActors(string[] actors)
        {
            foreach(var actor in actors)
            {
                Actors.Add(actor);
            }
        }
    }
}
