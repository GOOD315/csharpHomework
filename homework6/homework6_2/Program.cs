using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework6_2
{
    // Бабошин
    /// <summary>
    /// Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
    /// а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить 
    /// минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции. 
    /// б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через 
    /// параметр(с использованием модификатора out).
    /// </summary>
    class Program
    {
        public delegate double FuncDel(double x);

        public static double Func1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Func2(double x)
        {
            return x * x - 10 * x + 5;
        }

        public static double Func3(double x)
        {
            return x * x - x + 100;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, FuncDel F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static List<double> Load(string fileName, out double outMin)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            List<double> list1 = new List<double>();

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                list1.Add(d);
            }
            outMin = min;
            bw.Close();
            fs.Close();
            return list1;
        }
        static void Main(string[] args)
        {
            FuncDel[] funcDel = new FuncDel[3];
            funcDel[0] = Func1;
            funcDel[1] = Func2;
            funcDel[2] = Func3;
            Console.WriteLine("выберите функцию, которую хотите исследовать:");
            Console.WriteLine("1: x * x - 50 * x + 10");
            Console.WriteLine("2: x * x - 10 * x + 5");
            Console.WriteLine("3: x * x - x + 100");
            string funcMode = Console.ReadLine();

            Console.Write("введите начало отрезка: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("введите конец отрезка: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("введите шаг: ");
            double h = Convert.ToDouble(Console.ReadLine());


            switch (funcMode)
            {
                case "1":
                    SaveFunc("data.bin", a, b, h, funcDel[0]);
                    break;
                case "2":
                    SaveFunc("data.bin", a, b, h, funcDel[1]);
                    break;
                default:
                    SaveFunc("data.bin", a, b, h, funcDel[2]);
                    break;
            }

            double min;
            Load("data.bin", out min);
            Console.WriteLine(min);
            Console.ReadKey();
        }

    }
}
