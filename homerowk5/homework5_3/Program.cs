using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите строку 2: ");
            string str2 = Console.ReadLine();

            Console.WriteLine(isRestructured(str1, str2));
            Console.ReadLine();
        }

        public static bool isRestructured(string str1, string str2)
        {
            // делаю два словаря а потом сравниваю их
            Dictionary<char, int> chars1 = new Dictionary<char, int>();
            int charYet1;
            for (var i = 0; i < str1.Length; i++)
            {
                // проверка на то что такой элемент уже посчитан
                if (!chars1.TryGetValue(str1[i], out charYet1))
                {
                    int sum = 0;
                    sum = str1.Count(item => item == str1[i]);
                    chars1.Add(str1[i], sum);
                }
            }

            int charYet2;
            Dictionary<char, int> chars2 = new Dictionary<char, int>();
            for (var i = 0; i < str2.Length; i++)
            {
                // проверка на то что такой элемент уже посчитан
                if (!chars2.TryGetValue(str2[i], out charYet2))
                {
                    int sum = 0;
                    sum = str2.Count(item => item == str2[i]);
                    chars2.Add(str2[i], sum);
                }
            }

            // проверка двух словарей
            int sumLast = 0;
            foreach (KeyValuePair<char, int> kvp1 in chars1)
            {
                foreach (KeyValuePair<char, int> kvp2 in chars2)
                {
                    if ((kvp1.Key == kvp2.Key) && (kvp1.Value == kvp2.Value)) sumLast += 1;
                }
            }

            // если попаданий было столько же сколько сколько и длина первой и второй строк, то эти строки подходят
            if (sumLast == chars1.Count) return true; else return false;
        }
    }
}
