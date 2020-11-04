using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_1
{
    class Complex
    // Бабошин
    /* 
     * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
       б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
       в) Добавить диалог с использованием switch демонстрирующий работу класса.
    */

    {
        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;

        // Конструктор без параметров.
        public Complex()
        {
            im = 0;
            re = 0;
        }

        // Конструктор, в котором задаем поля.    
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public Complex(double re, double _im)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public Complex Multiply(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = re * x2.re - im * x2.im;
            x3.im = re * x2.im + im * x2.re;

            return x3;
        }
        public Complex Divide(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = (re * x2.re + im * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            x3.im = (im * x2.re - re * x2.im) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2));
            x3.re = Math.Round(x3.re, 1);
            x3.im = Math.Round(x3.im, 1);
            return x3;
        }
        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        // В методичке в этом методе нет override, у меня программа на это ругалась
        public override string ToString()
        {
            string str = "";

            if (re != 0) str += re;
            if (im != 0)
            {
                if ((re != 0) && (im > 0)) str += "+" + im + "i";
                else
                {
                    str += im + "i";
                }
            }
            if (str.Length == 0) str = "0";
            return str;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Boolean exit = false;

            while (exit == false)
            {
                Console.WriteLine("Первое комплексное число a+bi");
                Console.WriteLine("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Complex complex1 = new Complex(a, b);

                Console.WriteLine("Второе комплексное число a+bi");
                Console.WriteLine("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Complex complex2 = new Complex(a, b);

                Console.WriteLine(@"Введите цифру требуемой операции с этими числами:
1 - Сложение.
2 - Вычитание.
3 - Умножение.
4 - Деление.");
                Complex result = null;
                string strResult = "";
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        strResult = "сложения";
                        result = complex1.Plus(complex2);
                        break;
                    case 2:
                        strResult = "вычитания";
                        result = complex1.Minus(complex2);
                        break;
                    case 3:
                        strResult = "умножения";
                        result = complex1.Multiply(complex2);
                        break;
                    case 4:
                        strResult = "деления";
                        result = complex1.Divide(complex2);
                        break;
                }
                Console.WriteLine($"Результат выполнения операции {strResult}: {result}");
                Console.WriteLine("Нажмите любую клавишу что бы начать заного, или нажмите 0 что бы выйти из программы");
                if (Convert.ToInt32(Console.ReadLine()) == 0) exit = true; else exit = false;
            }
        }

    }
}
