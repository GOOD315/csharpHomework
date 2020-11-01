using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_6
{
    class Program
    {
        // Бабошин
        /* 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
              «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения 
              программы, используя структуру DateTime.
        */
        static void Main(string[] args)
        {
            ulong sum = 0;
            ulong sumOfNumbers;
            DateTime start = DateTime.Now;

            for (uint a = 1; a <= 1000000000; a++)
            {
                sumOfNumbers = 0;
                // подсчет цифр числа
                uint b = a;
                while (b > 0)
                {
                    sumOfNumbers = sumOfNumbers + b % 10;
                    b = b / 10;
                }

                if (a % sumOfNumbers == 0)
                {
                    sum = sum + a;
                }
            }
            Console.WriteLine($"сумма цифр: {sum}");
            Console.WriteLine($"время выполнения операции: {DateTime.Now - start}");
            Console.ReadLine();
        }
    }
}
}
