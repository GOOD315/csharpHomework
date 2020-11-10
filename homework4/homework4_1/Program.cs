using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_1
{
    class Program
    {
        // Бабошин
        /*1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 
        включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар 
        элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд 
        идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.  
        */
        static void Main(string[] args)
        {
            int[] arr1 = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr1[i] = rnd.Next(-10000, 10000);
            }
            StaticClass.ReadFile();
            //Console.WriteLine($"количество пар, где только одно число из них делится на 3: {StaticClass.Count(arr1)}");
            Console.ReadLine();
        }
    }
}
