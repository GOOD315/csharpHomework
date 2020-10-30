using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class task4
    {
        /*
        4. Написать программу обмена значениями двух переменных:
          а) с использованием третьей переменной;
          б) *без использования третьей переменной.
        */
        static void Swap1()
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
}
