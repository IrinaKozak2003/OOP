using System;

namespace Lab9
{
    public abstract class Director
    {
        protected string Name;


        protected Director(string name)
        {
            Name = name;
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
}