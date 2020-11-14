using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6_3
{
    // Бабошин
    /// <summary>
    /// 3. Переделать программу Пример использования коллекций для решения следующих задач: 
    /// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    /// в) отсортировать список по возрасту студента;
    /// г) * отсортировать список по курсу и возрасту студента;
    /// </summary>
    class Program
    {
        // метод для сравнения списка по курсу и возрасту
        static int MyDelegat(Student st1, Student st2)
        {
            if (st1.course == st2.course)
            {
                return st1.age.CompareTo(st2.age); // если курс совпадает - сравниваем возраст
            }
            else
            {
                if (st1.course > st2.course) return 1; else return -1;
            }
        }

        static void Main(string[] args)
        {
            int course5 = 0;
            int course6 = 0;
            bool dobavil = false; // флаг, который ставится если цикл нашел уже существующую kvp и добавил к ней +1

            List<Student> list = new List<Student>();                     // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_6.csv");
            Dictionary<int, int> studentCourse = new Dictionary<int, int>();
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество людей на курсах 5 и 6
                    if (int.Parse(s[6]) == 5) course5++;
                    if (int.Parse(s[6]) == 6) course6++;
                    if ((int.Parse(s[5]) <= 20) && (int.Parse(s[5]) >= 18))
                    {
                        dobavil = false;
                        foreach (KeyValuePair<int, int> kvp1 in studentCourse)
                        {
                            // если такой уже есть, то просто добавляю +1 к уже существующему, и ставлю флажок
                            if (int.Parse(s[6]) == kvp1.Key) studentCourse[kvp1.Key] = kvp1.Value + 1;
                            dobavil = true;
                        }
                        // если флажка нет, то добавляю новый ключ
                        if (!dobavil) studentCourse.Add(int.Parse(s[6]), 1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            // сортировка по курсу и возрасту
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("На 5 курсе:{0}", course5);
            Console.WriteLine("На 6 курсе:{0}", course6);
            foreach (KeyValuePair<int, int> kvp in studentCourse) Console.WriteLine($"на {kvp.Key} курсе {kvp.Value} студентов от 18 до 20 лет");
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }
    }
}
