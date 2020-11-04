using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_2
{
    class Program
    {
        // Бабошин
        /* 2. а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать 
           сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse. */
        static void Main(string[] args)
        {
            Int32 sum = 0;
            Int32 number = 1;

            Console.WriteLine("Введите числа:");
            while (number != 0)
            {
                bool success = Int32.TryParse(Console.ReadLine(), out number);
                if (success)
                {
                    if ((number % 2 == 1) && (number > 0))
                    {
                        sum += number;
                    }
                }
                else
                {
                    number = 1;
                    Console.WriteLine("Вы ввели не целое число");
                }
            }
            Console.WriteLine($"Сумма введенных целых положительных чисел {sum}");
            Console.ReadLine();
        }
    }
}
