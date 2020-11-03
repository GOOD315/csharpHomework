using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
    class Program
    {
        // Бабошин
        // 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            Int32 a = 1;
            Int32 count = 0;
            while (a != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if ((a % 2 != 0) && (a > 0))
                {
                    count++;
                }
            }
            Console.WriteLine($"количество подходящих по условию чисел: {count}");
            Console.ReadLine();
        }
    }
}
