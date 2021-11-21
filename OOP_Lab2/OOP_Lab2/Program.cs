using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOTP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод и вывод встроенных типов С#
            //Console.WriteLine("Input Int:");
            //int Integer = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Int {Integer}");

            //Console.WriteLine("Input Byte:");
            //byte Byte = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine($"Byte {Byte}");

            //Console.WriteLine("Input Char:");
            //char Char = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine($"Char {Char}");

            //Console.WriteLine("Input Double:");
            //double Double = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Double {Double}");

            //Console.WriteLine("Input Bool:");
            //bool Bool = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine($"Bool {Bool}");

            //Console.WriteLine("Input Float:");
            //float Float = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine($"Float {Float}");

            //Console.WriteLine("Input Long:");
            //long Long = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine($"Long {Long}");

            //Console.WriteLine("Input String:");
            //string String = Convert.ToString(Console.ReadLine());
            //Console.WriteLine($"String {String}");

            //Console.WriteLine("Input Short:");
            //short Short = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine($"Short {Short}");

            ushort Ushort = 7456;
            Console.WriteLine($"Ushort {Ushort}");

            uint Uint = 744576;
            Console.WriteLine($"Ushort {Uint}");

            ulong Ulong = 7456;
            Console.WriteLine($"Ulong {Ulong}");

            decimal Decimal = 7348456;
            Console.WriteLine($"Decimal {Decimal}");

            object Object = 7456;
            Console.WriteLine($"Object {Object}");

            sbyte Sbyte = 76;
            Console.WriteLine($"Sbyte {Sbyte}");


            //Неявное преобразование типов
            int integer = Ushort;
            float fl = Integer;
            short sh = Byte;
            decimal dec = Long;
            long lg = Uint;

            //Явное преобразование типов
            int a = (Int32)Uint;
            long b = (Int64)Ulong;
            short c = (Int16)Ushort;
            byte d = (Byte)Sbyte;
            double s = (Double)Float;

            //Упаковка и распаковка значимых типов
            int k = 1;
            object l = k;
            int o = (int)l;

            char notobj = 'i';
            object srtr = notobj;
            char hjg = (char)srtr;

            long m = 8767;
            object j = m;
            long h = (long)j;

            var v = 8767;
            object kh = v;
            char p = (char)k;

            //Неявно типизированная перенная
            var vds = 1;
            vds = '7';

            Nullable<int> z2 = 5;
            Nullable<bool> enabled2 = null;

            string str = "dfhhfs";
            string str1 = "dfhhfs";

            string str2 = "string1";
            string str3 = "string2";
            string str4 = "string3";

            if (str == str1)
            {
                Console.WriteLine($"str == str1");
            }

            string str6 = str2 + " " + str3;
            Console.WriteLine($"str2 + str3 == {str6}");
    
            string str7 = string.Copy(str2);
            Console.WriteLine(str7);

            string str8 = str4.Substring(3, 2);
            Console.WriteLine($"Substring {str8}");

            string s14 = "Эта строка, которая будет разделена на подстроки с использованием разделителей";
            string[] res = s14.Split(new char[] { ' ', ',' });
            foreach (string str14 in res)
            {
                Console.WriteLine(str14);
            }

            string str98 = str3.Insert(2, "str");
            Console.WriteLine(str98);

            string str87 = str3.Remove(2, 3);
   
            Console.WriteLine(str87);
            string empty = "";
            string Null = null;
            Console.WriteLine(string.IsNullOrEmpty(empty));
            Console.WriteLine(string.IsNullOrEmpty(Null));
            if(empty == Null)
            {
                Console.WriteLine("empty == null");
            }
            else
            {
                Console.WriteLine("empty != null");
            }
            Console.WriteLine(empty+ "string");

            //String builder
            StringBuilder SB = new StringBuilder("string", 50);
            SB.Append(new char[] { ' ','b', 'u' });
            SB.AppendFormat("ilding");
            Console.WriteLine(SB.ToString());

            //Arreys

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            for (int i = 0; i < 4; i++)
            {
                for (int n = 0; n < 3; n++)
                {
                    Console.Write("{0}\t", mas[i, n]);
                }
                Console.WriteLine();
            }
            string[] str_arr =  { "str1", "str2", "str3", "str4", "str5" };
            for (int i = 0; i < str_arr.Length; i++)
            {
                Console.WriteLine(str_arr[i] + '\t');
            }
            str_arr[3] = "str";

            Console.WriteLine('\n');

            for (int i = 0; i < str_arr.Length; i++)
            {
                Console.WriteLine(str_arr[i] + '\t');
            }

            Console.WriteLine("Array lenght: " + str_arr.Length);


            int[][] jag_arr = new int[3][];
            jag_arr[0] = new int[2]; 
            jag_arr[1] = new int[3]; 
            jag_arr[2] = new int[4];

            for (int i = 0; i < jag_arr.Length; i++)
            {
                for (int y = 0; y < jag_arr[i].GetLength(0); y++)
                {
                    int v1 = Convert.ToInt32(Console.ReadLine());
                    jag_arr[i][y] = v1;
                }
            }

            for (int i = 0; i < jag_arr.Length; i++)
            {
                for (int y = 0; y < jag_arr[i].GetLength(0); y++)
                {
                    Console.Write(jag_arr[i][y] + " ");
                }
                Console.WriteLine();
            }

            var t = jag_arr;
            var s12 = str2;

            //Кортежи

            (int, string, char, string, ulong) tuple = (12, "string", 'c', "string1", 346374);

            // риспаковка кортежей

            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item5);

            int e = tuple.Item1;
            string st= tuple.Item2;
            char ch= tuple.Item3;
            string str2000 = tuple.Item4;
            ulong ul = tuple.Item5;

             void Deconstruct(out int x, out string y, out char ch, out string str9, ulong u ) { x = tuple.Item1; y = tuple.Item2; ch = tuple.Item3; str9 = tuple.Item4; u = tuple.Item5;}


            (int, int) e1 = (1, 1);
            (int, int) e2 = (1, 1);

             if(e1 == e2)
            {
                Console.WriteLine(" e1 == e2");
            }
            else
            {
                Console.WriteLine("e1 != e2");
            }
             //Функция
             (int, int, int, char) func( int[] arr, string str45) 
            {
                return (arr.Max(), arr.Min(), arr.Sum(), str45[0]);
            }

            int[] ar = { 1, 2, 3 };
            string str55 = "string";
            (int, int, int, char) aa = func(ar, str55);
            Console.WriteLine( aa);

            // checked/unchecked
            void fun1()
            {
                try
                {
                    checked
                    {
                        int x = int.MaxValue;
                        x++;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            void fun2()
            {
                try
                {
                    unchecked // Не вызывает OverflowException
                    {
                        int x = int.MaxValue;
                        x++;
                        
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            fun1();
            fun2();
            Console.ReadKey();

        }
    }
}
