using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_5
{
    class Program
    {
        // Бабошин
        /* 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
                нужно ли человеку похудеть, набрать вес или всё в норме.
              б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        */
        static void Main(string[] args)
        {
            Double currentWeight;
            Double currentHeight;
            Double currentImt;
            Double idealWeightLow;        // вес для нижнего предела
            Double idealWeightHigh;       // вес для верхнего предела
            Double idealImtLow = 18.5;   // нижний предел нормального имт
            Double idealImtHigh = 25;     // верхний предел нормального имт

            Console.Write("Введите ваш рост(в сантиметрах): ");
            currentHeight = Convert.ToDouble(Console.ReadLine()) / 100;  // перевод из сантиметров в метры
            Console.Write("Введите ваш вес: ");
            currentWeight = Convert.ToDouble(Console.ReadLine());
            currentImt = currentWeight / Math.Pow(currentHeight, 2);
            idealWeightLow = idealImtLow * Math.Pow(currentHeight, 2);
            idealWeightHigh = idealImtHigh * Math.Pow(currentHeight, 2);

            // округляю ИМТ для корректного сравнения
            if (Math.Round(currentImt) < Math.Round(idealImtLow))
            {
                Console.WriteLine($"Вам следует набрать {Math.Round(idealWeightLow - currentWeight)} кг");
            }
            else if (Math.Round(currentImt) > Math.Round(idealImtHigh))
            {
                Console.WriteLine($"Вам следует похудеть на {Math.Round(currentWeight - idealWeightHigh)} кг");
            }
            else
            {
                Console.WriteLine($"Ваш вес в норме");
            }
            Console.ReadLine();
        }
    }
}
