using System;

namespace ConsoleApplication1
{
    internal partial class Partial
    {
        private void Print2()
        {
            Console.WriteLine("file controller");
        }
    }

    public class Controller1
    {
        public void Program_time(TvGuide<Director> program)
        {
            foreach (var i in program._list)
                Console.WriteLine((i as TvProgram).Finish.Subtract((i as TvProgram).Start));
        }

        public void Films_in_2020(TvGuide<Director> film)
        {
            foreach (var i in film._list)
                if ((i as film).yaer_og_realise == 2020)
                    Console.WriteLine((i as film).film_name);
        }

        public void Count_adv(TvGuide<Director> adv)
        {
            Console.WriteLine(adv.Count());
        }
    }
}