using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    public abstract class Director
    {
        protected string Name;


        protected Director(string name)
        {
            Name = name;
            if (name.Length <= 2)
            {
                throw new Error("Слишком", name.Length);
            }
        }

        public new void ToString()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine(typeof(Director));
        }

        public virtual void Virtual()
        {
            Console.WriteLine("Interface Program");
        }
    }

    internal class ITvProgram
    {
        public void Redefinition()
        {
            Console.WriteLine("definition");
        }
    }

    public class TvProgram : Director
    {
        public DateTime Finish;
        public string PrName;
        public DateTime Start;

        public TvProgram(string name, string Pr_name, DateTime st, DateTime finish) : base(name)
        {
            PrName = Pr_name;
            Start = st;
            Finish = finish;
        }
    }

    public class film : Director
    {
        public string film_name;
        public int yaer_og_realise;

        public film(string s, string name, string film, int year_of_realise)
            : base(name)
        {
            Name = name;
            film_name = film;
            Debug.Assert(year_of_realise <0, "year < 0"); 
        }


        public void ToString()
        {
            Console.WriteLine($"film_name:{film_name}");
            Console.WriteLine($"name:{Name}");
            Console.WriteLine($"yaer_og_realise:{film_name}");
            Console.WriteLine(typeof(film));
        }

        public override void Virtual()
        {
            Console.WriteLine("override");
        }
    }

    internal class news : TvProgram
    {
        private readonly string sport_news;
        private readonly string weather;

        public news(string weather, string sport, string name, string Pr_name, DateTime st, DateTime finish) : base(
            name, Pr_name, st, finish)
        {
            sport_news = sport;
            this.weather = weather;
        }

        public void Redefinition()
        {
            Console.WriteLine("Redefinition");
        }

        public void ToString()
        {
            Console.WriteLine($"sport_news:{sport_news}");
            Console.WriteLine($"weather:{weather}");
            Console.WriteLine(typeof(news));
        }

        private enum daytime
        {
            mormimg,
            afternoon,
            evening
        }
    }

    public class advertisement : Director
    {
        private string prodact;

        public advertisement(string name) : base(name)
        {
            Name = name;
        }

        public void ToString()
        {
            Console.WriteLine($"prodact:{prodact}");
            Console.WriteLine(typeof(news));
        }
    }

    internal class Art_film : film
    {
        private readonly string art_film;

        public Art_film(string name, string program, string Program_name, string film, string art,
            int year_of_realise) :
            base(name, program, film, year_of_realise)
        {
            art_film = art;
        }

        public void ToString()
        {
            Console.WriteLine($"art_film:{art_film}");
            Console.WriteLine(typeof(Art_film));
        }
    }

    internal class multfilm : film
    {
        private string mult;

        public multfilm(string name, string program, string film, int year_of_realise) : base(name, program,
            film, year_of_realise)
        {
        }

        public void ToString()
        {
            Console.WriteLine($"mult:{mult}");
            Console.WriteLine(typeof(multfilm));
        }
    }

    internal partial class Partial
    {
        public void Print1()
        {
            Console.WriteLine("file classes");
        }
    }
}