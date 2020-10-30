using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    // Бабошин Дмитрий
    class Program
    {
        static void Main(string[] args)
        {
            Anketa ank1 = new Anketa();
            MyClass1 myClass1 = new MyClass1();
            // 1,2 задание
            ank1.Initiate();
            // 3 задание
            Console.Clear();
            Console.WriteLine(Calculate(5.23, 2.1, 3.22, 3));
            myClass1.Pause();
            // 4 задание
            Swap();
            // 5,6 задание
            Console.Clear();
            myClass1.Print($"{ank1.firstName} {ank1.lastName} возраст: {ank1.age} рост: {ank1.height} " +
                $"вес: {ank1.weight} ИМТ: {ank1.imt}");
        }


        /*
        3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по 
           формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f 
           (с двумя знаками после запятой);
           б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        */
        static float Calculate(Double x1, Double x2, Double y1, Double y2)
        {
            double rr = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            float r = (float)Math.Round(rr, 2);
            return r;
        }


        /*
        4. Написать программу обмена значениями двух переменных:
           а) с использованием третьей переменной;
	       б) *без использования третьей переменной.
        */
        static void Swap()
        {
            Int32 A = 10;
            Int32 B = 20;
            Int32 C;
            Console.WriteLine($"{A}  {B}");
            C = A;
            A = B;
            B = C;
            Console.WriteLine($"{A}  {B}");
        }
    }


    /* 
      1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
      В результате вся информация выводится в одну строчку:
         а) используя  склеивание;
         б) используя форматированный вывод;
         в) используя вывод со знаком $.
      2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
      где m — масса тела в килограммах, h — рост в метрах.
    */
    class Anketa
    {
        public String firstName;
        public String lastName;
        public String age;
        public Int32 height;
        public Int32 weight;
        public Int32 imt;
        public void Initiate()
        {

            Console.Write("Введите ваше имя: ");
            firstName = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Console.ReadLine();
            Console.Write("Введите ваш рост: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш вес: ");
            weight = Convert.ToInt32(Console.ReadLine());
            imt = (weight / height ^ 2);
            Console.WriteLine(firstName + ' ' + lastName + " возраст: " + age + " рост: " + height + " вес: " + weight + " ИМТ: " + imt);
            Console.WriteLine("{0} {1} возраст: {2} рост: {3} вес: {4} ИМТ: {5}", firstName, lastName, age, height, weight, imt);
            Console.WriteLine($"{firstName} {lastName} возраст: {age} рост: {height} вес: {weight} ИМТ: {imt}");
        }
    }


    /* 
      5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         б) *Сделать задание, только вывод организовать в центре экрана.
         в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
    */
    class MyClass1
    {
        public void Print(string str)
        {
            int centerX = (Console.WindowWidth / 2) - (str.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine(str);
            Console.SetCursorPosition(centerX, centerY + 1);
            Pause();
        }

        public void Pause()
        {
            Console.Write("Для окончания введите любую клавишу...");
            Console.ReadLine();
        }
    }
}
