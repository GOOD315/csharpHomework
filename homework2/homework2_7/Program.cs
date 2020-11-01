using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_7
{
    class Program
    {
        // Бабошин
        /* 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
              б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        */
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма всех чисел: {Move(a, b)}");
            Console.ReadLine();
        }

        static int Move(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                return Move(a + 1, b) + a;
            }
            else
            {
                return 0;
            }
        }

    }
}
