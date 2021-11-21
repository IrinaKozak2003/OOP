using System;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                var date1 = new DateTime(2015, 7, 20, 18, 30, 25);
                var date2 = new DateTime(2015, 7, 20, 19, 30, 25);
                var date3 = new DateTime(2014, 7, 20, 13, 10, 25);
                var date4 = new DateTime(2014, 7, 20, 19, 30, 25);
                var pr1 = new TvProgram("p12", "oe", date1, date2);
                var pr2 = new TvProgram("pr2", "ofd", date3, date4);
                var adv1 = new advertisement("fdgh");
                var adv2 = new advertisement("jvh");
                var film1 = new film("fkjg", "fhdfj", "hg", 2020);
                var film2 = new film("kfdjg", "fhdfj", "hg", -1998);
                var list1 = new TvGuide<Director>();
                var list2 = new TvGuide<Director>();
                var list3 = new TvGuide<Director>();
                list1.Add(pr1);
                list1.Add(pr2);
                list2.Add(adv1);
                list2.Add(adv2);
                list3.Add(film1);
                list3.Add(film2);
                var cont1 = new Controller1();
                cont1.Program_time(list1);
                cont1.Count_adv(list2);
                cont1.Films_in_2020(list3);
            }
            catch (Error err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("end");
            }
        }
    }
}