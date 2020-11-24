using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8_1
{
    // Бабошин
    // 1. С помощью рефлексии выведите все свойства структуры DateTime
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(DateTime);
            foreach (var prop in t.GetProperties())
                Console.WriteLine(prop.Name);
            Console.ReadLine();
        }
    }
}
