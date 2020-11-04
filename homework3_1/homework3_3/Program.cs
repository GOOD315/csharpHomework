using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_3
{
    // Бабошин
    /*
    3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
    Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    Написать программу, демонстрирующую все разработанные элементы класса.
    * Добавить свойства типа int для доступа к числителю и знаменателю;
    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    * Добавить упрощение дробей.
   */
    class Fraction
    {
        int num { get; set; }
        int den { get; set; }

        public Fraction(int num, int den = 1)
        {
            if (den == 0) throw new ArgumentException("В знаменателе не может быть нуля");
            this.num = num;
            this.den = den;
        }

        public static Fraction operator +(Fraction a) { return a; }
        public static Fraction operator -(Fraction a) { return new Fraction(-a.num, a.den); }
        public static Fraction operator +(Fraction a, Fraction b)
        { return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den); }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }
        public override string ToString()
        {
            Simplify();
            if (Math.Abs(den) == 1) return $"{num}";
            else return $"{num}/{den}";
        }
        public void Simplify()
        {
            // взял по модулю, потому что 
            int a = Math.Abs(num);
            int b = Math.Abs(den);
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            num = num / (a + b);
            den = den / (a + b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Boolean exit = false;

            while (exit == false)
            {
                Console.WriteLine("Введите числитель первой дроби: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите знаменатель первой дроби: ");
                int den1 = Convert.ToInt32(Console.ReadLine());
                Fraction frac1 = new Fraction(num1, den1);

                Console.WriteLine("Введите числитель второй дроби: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите знаменатель второй дроби: ");
                int den2 = Convert.ToInt32(Console.ReadLine());
                Fraction frac2 = new Fraction(num2, den2);

                Console.WriteLine(@"Введите цифру требуемой операции с этими числами:
1 - Сложение.
2 - Вычитание.
3 - Умножение.
4 - Деление.");
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine($"результат сложения: {frac1 / frac2}");
                        break;
                    case 2:
                        Console.WriteLine($"результат вычитания: {frac1 / frac2}");
                        break;
                    case 3:
                        Console.WriteLine($"результат умножения: {frac1 / frac2}");
                        break;
                    case 4:
                        Console.WriteLine($"результат деления: {frac1 / frac2}");
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу что бы начать заного, или нажмите 0 что бы выйти из программы");
                if (Convert.ToInt32(Console.ReadLine()) == 0) exit = true; else exit = false;
                Console.Clear();
            }
        }
    }
}
