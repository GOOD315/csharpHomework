using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6_1
{
    // Бабошин
    /// <summary>
    ///  1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    ///  Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    /// </summary>
    class Program
    {
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }


        public delegate double Fun(double x, double a);

        public static double Func1(double x, double a)
        {
            return a * x * x;
        }

        public static double Func2(double x, double a)
        {
            return a * Math.Sin(x);
        }


        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Table(Func2, 0, 10, a);
            Console.ReadLine();
        }
    }
}
