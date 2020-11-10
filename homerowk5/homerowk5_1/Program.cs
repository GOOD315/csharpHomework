using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace homerowk5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a1sd23s";

            // Без использования регулярного выражения
            if (str.Length <= 10)
            {
                char a = str[0];
                int b;
                if (Int32.TryParse(a.ToString(), out b))
                {
                    Console.WriteLine("Логин некорректный");
                }
                else Console.WriteLine("Логин корректный");
            }
            else Console.WriteLine("Логин некорректный");


            // С использованием регулярного выражения
            string regExp = @"^[a-z]{1}([a-z]|\d){1,9}$";
            if (Regex.IsMatch(str, regExp, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Логин корректный");
            }
            else Console.WriteLine("Логин некорректный");
            Console.ReadLine();
        }
    }
}
