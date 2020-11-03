using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        // Бабошин
        // 1. Написать метод, возвращающий минимальное из трёх чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine($"Наименьшее число: {a}");
                }
                else
                {
                    Console.WriteLine($"Наименьшее число: {c}");
                }
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine($"Наименьшее число: {b}");
                }
                else
                {
                    Console.WriteLine($"Наименьшее число: {c}");
                }
            }
            Console.ReadLine();
        }
    }
}
