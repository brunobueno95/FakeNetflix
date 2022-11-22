using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNetflix
{
    internal class SearchEngine : ISearchEngine
    {


        public List<IContent> SearchByGenre(string genreChoice, List<IContent> allcontent)
        {
            var GenreChosenList = allcontent.FindAll(c => c.Genre == genreChoice);
            return GenreChosenList;

        }

        public List<IContent> SearchByActor(string ActorChoise, List<IContent> allcontent)
        {
            var ActorChosenList = allcontent.FindAll(c => c.Actors.Contains(ActorChoise));
            return ActorChosenList;
        }

        public List<IContent> SearchByTitle(string TitleChoise, List<IContent> allcontent)
        {
            var TitleChosenList = allcontent.FindAll(t => t.Title == TitleChoise);
            return TitleChosenList;
        }

    }
}
