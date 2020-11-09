using System;
using System.Collections.Generic;
using System.IO;

namespace homework4_1
{
    public static class StaticClass
    {
        public static int Mylength { get; set; }


        public static int Count(int[] arr1)
        {
            int cnt1 = 0;
            for (int i = 0; i < 19; i++)
            {
                if ((arr1[i] % 3 == 0) ^ (arr1[i + 1] % 3 == 0))
                {
                    cnt1++;
                }
            }
            return cnt1;
        }
        public static void ReadFile()
        {
            List<int> numbers = new List<int>();
            int[] arr = new int[1];

            string line;
            int line2;

            if (File.Exists("file.txt"))
            {
                StreamReader sr = new StreamReader("file.txt");
                while ((line = (sr.ReadLine())) != null)
                {
                    bool success = Int32.TryParse(line, out line2);
                    if (success)
                    {
                        line2 = 0;
                    }
                    else
                    {
                        continue;
                    }
                    numbers.Add(line2);
                }
                arr = numbers.ToArray();
                sr.Close();

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Такого файла нет");
            }
            Console.ReadLine();
        }
    }
}
