using System;

namespace OOP_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AlexMarks = {7,9 ,9 ,8};
            int[] AntonMarks = {7,4 ,2 ,7};
            int[] MihailMarks = {4,6 ,2 ,3};
            int[] ArtemMarks = {7,6 ,7 ,8};
            int[] KrisMarks = {10,9 ,9 ,10};
            int[] Test = {10,9 ,9 ,10};
            int Id = 7;
            Abiturient[] abiturients = new Abiturient[5];

            abiturients[0] = new Abiturient(KrisMarks);
            abiturients[1] = new Abiturient(1, "Alexandr", "Mozolovskiy", "Dmitrievich", " Brest", 4476346,  AlexMarks);
            abiturients[2] = new Abiturient( out Id,"Muraviev", "Igorevich", "Baranovichi", 73456374, AntonMarks);
            abiturients[3] = new Abiturient(3, "Mihail", "Zinovich", "Vitalievich", "Drogichin", 37476538,  MihailMarks);
            abiturients[4] = new Abiturient(4, "Artem", "Sinkevich", "Dmitrievich", "Grodno", 46537475,  ArtemMarks);
            Abiturient test = new Abiturient(5, "0000", "0000", "0000", "0000", 0000,  Test);
            test.X = "Использование get и set";
            string x = test.X;
            Console.WriteLine(x);
            Console.WriteLine($"Количество объектов:{Abiturient.count}");
            Abiturient.Inf();
            u t = new u();
            t.x();
            t.y();
            var v = new { Name = "var", id = 5 };
            Console.WriteLine(v.id);
            Console.WriteLine("Список студентов с нудовлеворительными оценками: ");
            for(int i =0; i < 5; i++)
            {
                bool flag = false;
                for (int j = 0; j < 4; j++)
                {
                    if (abiturients[i].marks[j] < 4)
                    {
                        flag = true;
                    }
                } 
               if (flag)
                    {
                        Console.WriteLine(abiturients[i].Surname+" "+abiturients[i].Name+ " "+abiturients[i].LastName);

                  }
            }
            Console.WriteLine("Список студентов с cуммой балллов < 16: ");
            for (int i = 0; i < 5; i++)
            {

                int sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum = sum + abiturients[i].marks[j];
                }
                if (sum<16)
                {
                    Console.WriteLine(abiturients[i].Surname + " " + abiturients[i].Name + " " + abiturients[i].LastName);

                }
            }
        }

    }
     public class Abiturient
    {
        public readonly int id;
        public string Name;
        public string Surname;
        public string LastName;
        public string Adress;
        public int Tel;
        public int[] marks;
        public int GPA;
        public int Max;
        public int Min;
        public const int con  = 0;
        private string x;
        public static int count = 0;
        
        public static void Inf()
        {
            Console.WriteLine("Класс содержит информациою о обитуриенте");
        }
        

        public string X
        {
            get { return x; }
            set { x = value; }
        }

        public Abiturient(  int  id, string Name, string Surname, string LastName, string Adress,   int  Tel, int[] marks)
        {
          
            this.id = id;
            this.Name = Name;
            this.Surname = Surname;
            this.LastName = LastName;
            this.Adress = Adress;
            this.Tel = Tel;
            this.marks = new int[4];
            for (int i = 0; i < 4; i++)
            {
                this.marks[i] = marks[i];
            }
            this.GPA = 0;
            this.Min = 0;
            this.Max = 0;
            count++;
        }
        public Abiturient(int[] marks)
        {
            this.id = 0;
            this.Name = "Kris";
            this.Surname = "Minevich";
            this.LastName = "Victorovna";
            this.Adress = "Belarusskaya 21";
            this.Tel = 4756374;
            this.marks = new int[4];
            for (int i=0; i<4;i++ )
            {
                this.marks[i] = marks[i];
            }
            this.GPA = 0;
            this.Min = 0;
            this.Max = 0;
            count++;
        }
        public Abiturient( out int id, string Surname, string LastName, string Adress, int Tel, int[] marks)
        {
            id = 2;
            this.id = id;
            this.Name = "Anton";
            this.Surname = Surname;
            this.LastName = LastName;
            this.Adress = Adress;
            this.Tel = Tel;
            this.marks = new int[4];
            for (int i = 0; i < 4; i++)
            {
                this.marks[i] = marks[i];
            }
            this.GPA = 0;
            this.Min = 0;
            this.Max = 0;
            count++;
        }
        public void gpa()
        {
            
            foreach(int i in marks)
            {
                GPA += marks[i]; 
            }
            GPA /= marks.Length;
            Console.WriteLine($"Средниий балл: {GPA}");
        }
        public void max()
        {
            foreach(int i in marks)
            {
                if (marks[i] > Max)
                {
                    Max = marks[i];
                }
            }
            Console.WriteLine($"Максимальный балл:{Max}");
        }
        public void min()
        {
            Min = marks[0];
            foreach(int i in marks) 
            { 
                if(Min > marks[i])
                {
                    Min = marks[i];
                }
            }
            Console.WriteLine($"Минрмальный балл:{Min}");
            
        }
        static Abiturient()
        {
            Console.WriteLine("Стаический конструктор");
        }
       
    } 
    public partial class u
        {
            public void x()
            {
                Console.WriteLine("Использование ");
            }
        }
        public partial class u
        {
            public void y ()
            {
                Console.WriteLine("partial ");
            }
        }
}
