using System;

namespace Lab9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var set1 = new Set<int>
            {
                1, 2, 3, 4, 5, 6
            };
            var set2 = new Set<int>
            {
                4, 5, 6, 7, 8, 9
            };

            var set3 = new Set<int>
            {
                2, 3, 4
            };
            var b = set1 > 1;
            Console.WriteLine($" принадлежит ли 1 множесмтву set1 {b}");
            var a = set3 < set1;
            Console.WriteLine($" принадлежит ли set3 множесмтву set1 {a}");
            var s = set1 * set3;
            Console.WriteLine("пересечение set1 и set3:");
            for (var i = 0; i < s.Count; i++) Console.WriteLine(i);


            var date1 = new DateTime(2015, 7, 20, 18, 30, 25);
            var date2 = new DateTime(2015, 7, 20, 19, 30, 25);
            var set6 = new Set<Director>();
            var pr1 = new TvProgram("p12", "oe", date1, date2);
            set6.Add(pr1);
            var date3 = new DateTime(2014, 7, 20, 13, 10, 25);
            var date4 = new DateTime(2014, 7, 20, 19, 30, 25);
            var pr2 = new TvProgram("pr2", "ofd", date3, date4);
            var film1 = new film("fkjg", "fhdfj", "hg", 2020);
            var film2 = new film("kfdjg", "fhdfj", "hg", -1998);
            
            //5 задание
            var doubleArray = new double[] { };
            doubleArray = Set<double>.ReadFromFile<double>();
        }
    }
}