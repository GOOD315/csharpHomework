using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем массив
            Console.WriteLine("Введите первую размерность массива: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую размерность массива: ");
            int j = Convert.ToInt32(Console.ReadLine());
            // далее вызываем конструктор
            myLibrary.myArray arr = new myLibrary.myArray(i, j);
            // либо можно задать конструктор так:
            myLibrary.myArray arr2 = new myLibrary.myArray("file.txt");
            // далее можно по очереди вызвать методы и свойства массива:
            int max = arr.maxValue;
            int min = arr.minValue;
            arr.Sum();
            arr.Sum("file.txt");
            arr.SumMax(50);
            arr.SumMax("file.txt", 50);
            arr.FindMax();
            arr.FindMax("file.txt");
        }
    }
}
