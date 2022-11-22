using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNetflix
{
    internal interface IContent
    {
        string Title { get; set; }        
        List <string> Actors { get; set; }
        double Duration { get; set; }      
        string Genre { get; set; }
        bool LikedOrNot { get; set;}

        void Liked();

        void AddActors(string[] actors);

       

    }
}
