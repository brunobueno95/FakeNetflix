namespace FakeNetflix
{
    internal interface ISearchEngine
    {
        List<IContent> SearchByActor(string ActorChoise, List<IContent> allcontent);
        List<IContent> SearchByGenre(string genreChoice, List<IContent> allcontent);
        List<IContent> SearchByTitle(string TitleChoise, List<IContent> allcontent);
    }
}