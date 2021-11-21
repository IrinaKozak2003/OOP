using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab9;

namespace Lab9
{
    public interface generalized<T>
    {
    }
}

public class Set<T> : generalized<T>, IEnumerable // множество Set
{
    public List<T> items = new();
    public int Count => items.Count; // счётчик

    public IEnumerator GetEnumerator()
    {
        for (var i = 0; i < items.Count; i++) yield return items[i];
    }

    public void Add(T item) // добавление только неповторяющихся элементов
    {
        if (items.Contains(item)) return;

        items.Add(item);
    }

    public void Remove(T item) //удаление элементов
    {
        items.Remove(item);
    }
    //перегрузка операций


    public static bool operator >(Set<T> item1, T item2)
    {
        if (item1.items.Contains(item2))
            return true;
        return false;
    }

    public static bool operator <(Set<T> item1, T item2)
    {
        throw new NotImplementedException();
    }

    public static bool operator <(Set<T> set1, Set<T> set2)
    {
        // Проверяем входные данные на пустоту.
        if (set1 == null) throw new ArgumentNullException(nameof(set1));

        if (set2 == null) throw new ArgumentNullException(nameof(set2));

        var result = set1.items.All(s => set2.items.Contains(s));
        return result;
    }

    public static bool operator >(Set<T> set1, Set<T> set2)
    {
        throw new NotImplementedException();
    }

    public static Set<T> operator *(Set<T> set1, Set<T> set2)
    {
        if (set1 == null) throw new ArgumentNullException(nameof(set1));

        if (set2 == null) throw new ArgumentNullException(nameof(set2));

        var resultSet = new Set<T>();
        if (set1.Count < set2.Count)
        {
            foreach (var i in set1.items)
                if (set2.items.Contains(i))
                    resultSet.Add(i);
        }
        else
        {
            foreach (var i in set2.items)
                if (set1.items.Contains(i))
                    resultSet.Add(i);
        }

        return resultSet;
    }

    public static Set<T> Date(object obj, Set<T> set)
    {
        set = (Set<T>) obj;
        return set;
    }

    private void Owner()
    {
        var ID = 8;
        var Name = "Irina";
        var Organization = "BGTU";
    }

    private class Date1
    {
        private DateTime someDate = new(2021, 10, 21);
    }

    private static class StatisticOperation
    {
        private static int M(Set<T> set)
        {
            var c = set.Count;
            return c;
        }

        public static void Method1()
        {
            static void Method2(string str)
            {
                var a = "1234567890";
                var l = 0;
                foreach (var i in str)
                {
                    var k = false;
                    foreach (var j in a)
                        if (i == j)
                        {
                            l = i;
                            Console.WriteLine(l);
                        }
                }
            }

            static void Method3(Set<int> set)
            {
                for (var i = 0; i < set.Count; i++)
                    if (i > 0)
                        set.Remove(i);
            }
        }
    }
    public static T[] ReadFromFile<T>()
    {
        using (StreamReader sw = new StreamReader(@"D:\Универ\2 курс\oop_labs от 4\OOP_Lab8\OOP_Lab8\data.txt"))
        {
            string[] items = sw.ReadToEnd().Split(Convert.ToChar("-->"));
                
            T[] outputItems = new T[items.Length];
            
            int counter = 0;
            foreach (string item in items)
            {
                outputItems[counter] = (T)Convert.ChangeType(item, typeof(T));
                counter++;
            }

            return outputItems;
        }
        //TODO как-то обобщить это
    }
}