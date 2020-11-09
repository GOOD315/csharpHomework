using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework4_3_lib;

namespace homework4_3
{
    class Program
    {
        // Бабошин
        /* 3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
           б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
           е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
        */
        static void Main(string[] args)
        {
            // принимаю три параметра, отправляю их в конструктор
            Console.Write("Задайте первый элемент массива: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте размер массива: ");
            int cnt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте шаг массива: ");
            int step = Convert.ToInt32(Console.ReadLine());
            myArray arr1 = new myArray(fNum, cnt, step);

            Console.WriteLine(arr1);
            Console.WriteLine($"количество максимальных элементов в массиве: { arr1.FindMax()}");

            // принт словаря в консоль
            Dictionary<int, int> myDictionary = arr1.ElementFrequency();
            foreach (KeyValuePair<int, int> keyValue in myDictionary)
            {
                Console.WriteLine($"Цифра: {keyValue.Key} содержится в массиве {keyValue.Value} раз ");
            }

            Console.ReadLine();
        }
    }
}
