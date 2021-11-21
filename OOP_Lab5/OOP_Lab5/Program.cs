using System;

namespace WebApplication
{

    public abstract class Regeser
    {
        protected string name;


        public Regeser(string name)
        {
            this.name = name;

        }

        public void ToString()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine(typeof(Regeser));
        }

        public virtual void Program()
        {
            Console.WriteLine("Interface Program");
        }
    }

    interface Program
    {
      
       void Program();

       public void ToString();
    }

    class film : Regeser
    {
        private string film_name;

        public film(string s, string name, string film)
            : base(name)
        {
            base.name = name;
            this.film_name = film;

        }



        public void ToString()
        {
            Console.WriteLine($"film_name:{film_name}");
        }

        public override void Program()
        {
            Console.WriteLine("override");
        }

    }

    class news : Program
    {
        private string sport_news;

        public news(string name, string sport)

        {
            this.sport_news = sport;

            void Program()
            {
                Console.WriteLine("Переопределение");
            }
        }

        void Program.Program()
        {
            throw new NotImplementedException();
        }

        public void ToString()
        {
            Console.WriteLine($"sport_news:{sport_news}");
        }

    }

    class advertisement : Regeser
    {
        private string prodact;

        public advertisement(string name) : base(name)
        {
            this.name = name;

        }

        public void ToString()
        {
            Console.WriteLine($"prodact:{prodact}");
        }
    }

    class Art_film : film
    {
        private string art_film;

        public Art_film(string name, string program, string Program_name, string film, string art) :
            base(name, program, film)
        {
            art_film = art;
        }

        public void ToString()
        {
            Console.WriteLine($"art_film:{art_film}");
        }
    }

    class multfilm : film
    {
        private string mult;

        public multfilm(string name, string program, string film) : base(name, program,
            film)
        {
        }

        public void ToString()
        {
            Console.WriteLine($"mult:{mult}");
        }
    }

    sealed class Sealed
    {
        public void ToString()
        {
            Console.WriteLine("Sealed");
        }
    }

    class Lab5
    {
        static void Main(string[] args)
        {
            film film1 = new film("film1", "fnffjgn", "film1");
            film1.ToString();
            Regeser f = film1 as Regeser;
            if (f == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
                
            }
            else
            {
                f.ToString();
            }
            news person = new news("Tom","skiing");
            if(person is Program)
            {
                Program P = (Program)person;
                P.ToString();
            }
            else
            {
                Console.WriteLine("fmgfkmg");
            }
            film1.Program();
            Program program = new news("dmf", "djfh");
            Printer pr = new Printer();
            }
        class Printer
        {
            public static void IAmPrinting(Program someObj)
            {
                if (someObj is Program)
                     someObj.ToString();
                else
                {
                    news tempCir = someObj as news;
                    if (tempCir != null)
                        tempCir.ToString();
                }
            }
        }
    }
}
    