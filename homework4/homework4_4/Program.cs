using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_4
{
    // Бабошин
    /// <summary>
    /// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру 
    /// Account, содержащую Login и Password.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("file.txt");
            Console.ReadLine();
        }
    }
}
