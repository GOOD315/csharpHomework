using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_2
{
    class Program
    {
        // Бабошин
        // 2. Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Int32 a = Convert.ToInt32(Console.ReadLine());
            Int32 b = 0;
            while (a > 0)
            {
                b += 1;
                a = a / 10;
            }
            Console.WriteLine($"Количество цифр в этом числе: {b}");
            Console.ReadLine();
        }
    }
}
