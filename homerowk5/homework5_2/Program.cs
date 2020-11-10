using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_2
{
    // Бабошин
    /// <summary>
    /// 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста: а) Вывести только 
    /// те слова сообщения,  которые содержат не более n букв. 
    /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ. 
    /// в) Найти самое длинное слово сообщения. 
    /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. 
    /// д) *** Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов 
    /// и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется 
    /// использовать класс Dictionary.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Message.Content = Console.ReadLine();
            /*
                        // вызов метода из пункта а)
                        Console.Write("Введите число букв(а): ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Message.PrintSmallWords(n));

                        // вызов метода из пункта б)
                        Console.Write("Введите символ(б): ");
                        char symb = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine(Message.RemoveWords(symb));

                        // вызов метода из пункта в)
                        Console.WriteLine($"Самое длинное слово сообщения: {Message.FindLongestWord()}");

                        // вызов метода из пункта г)
                        Console.WriteLine($"массив из самых длинных слов сообщения: {Message.buildLongString()}");
            */
            // вызов метода из пункта д)    
            Console.Write("Введите последовательность знаков: ");
            string str = (Console.ReadLine());
            Console.WriteLine(Message.FrequencyAnalysis(str));

            Console.ReadLine();
        }
    }
}
