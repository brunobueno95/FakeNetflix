using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNetflix
{
    internal class App : IApp
    {

        public List<IContent> AllContent { get; set; }

        ISearchEngine SearchEngine = new SearchEngine();


        public void RunApp()
        {
 
            FillUpContent();
            Greeting();
            ChosenSearch(ValidateFirstInput());
        }


        public void Greeting()
        {
            Console.WriteLine("Hello, welcome to fake netflix");
            Console.WriteLine("Search the TVshow or Movie u want to watch. Press the number infront of the seach u want to do it");
            Console.WriteLine("1 - Search by Genre");
            Console.WriteLine("2 - Search by Actor");
            Console.WriteLine("3 - Search by Title");

        }


        public int ValidateFirstInput()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "1")
                {
                    return 1;
                }

                else if (input == "2")
                {
                    return 2;
                }
                else if( input == "3")
                {
                    return 3;
                }

                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }
        }

        public void ChosenSearch(int validInput)
        {
            if(validInput == 1)
            {
                var inputGenre = Console.ReadLine();
                ShowSearchGenre(inputGenre);

            }
            else if(validInput == 2)
            {
                var inputActor = Console.ReadLine();
                ShowSearchActor(inputActor);
            }
            else if (validInput == 3)
            {
                var inputTitle = Console.ReadLine();
                ShowSearchTitle(inputTitle);
            }
        }

        public void ShowSearchGenre(string input)
        {
          var Search =  SearchEngine.SearchByGenre(input, AllContent);

            if(Search.Count > 0)
            {
                foreach (var content in Search)
                {
                    Console.WriteLine(content.Title);
                }
            }
           else
            {
                Console.WriteLine("No match for ur search");
            }

        }
        public void ShowSearchActor(string input)
        {
            var Search = SearchEngine.SearchByActor(input, AllContent);

            if (Search.Count > 0)
            {
                foreach (var content in Search)
                {
                    Console.WriteLine(content.Title);
                }
            }
            else
            {
                Console.WriteLine("No match for ur search");
            }

        }
        public void ShowSearchTitle(string input)
        {
            var Search = SearchEngine.SearchByTitle(input, AllContent);

            if (Search.Count > 0)
            {
                foreach (var content in Search)
                {
                    Console.WriteLine(content.Title);
                }
            }
            else
            {
                Console.WriteLine("No match for ur search");
            }

        }
        public void FillUpContent()
        {
            AllContent = new List<IContent>();
            var Gt = new TvShow("Game Of Thrones", 120, "Action", 5, 10);
            string[] gtAct = { "Maria", "James" };
            Gt.AddActors(gtAct);
            AllContent.Add(Gt);

            var AH = new TvShow("American Horror", 120, "Horror", 5, 10);
            string[] AHact = { "James", "Kevin" };
            AH.AddActors(AHact);
            AllContent.Add(AH);

            var B99 = new TvShow("B99", 20, "Comedy", 8, 15);
            string[] B99Acts = { "Tom", "Linda", "Susan" };
            B99.AddActors(B99Acts);
            AllContent.Add(B99);

            var Tp = new Movie("Top Gun", 120, "Action", true);
            string[] tpAct = { "Tom", "Sean" };
            Tp.AddActors(tpAct);
            AllContent.Add(Tp);

            var Hg = new Movie("Hangover", 120, "Comedy", true);
            string[] HgAct = { "Joana", "Bradd" };
            Tp.AddActors(tpAct);
            AllContent.Add(Tp);

            var Ab = new Movie("Annabell", 90, "Horror", false);
            string[] AbAct = { "Annabell", "Steve" };
            Tp.AddActors(AbAct);
            AllContent.Add(Ab);
        }
    }
}
