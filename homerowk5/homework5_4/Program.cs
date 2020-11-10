using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_4
{/// <summary>
 /// *Задача ЕГЭ.
 /// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.В первой строке 
 /// сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий 
 /// формат: <Фамилия> <Имя> <оценки>, где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая 
 /// не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
 /// <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
 /// Иванов Петр 4 5 3
 /// Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по 
 /// среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, 
 /// следует вывести и их фамилии и имена.
 /// Достаточно решить 2 задачи.Старайтесь разбивать программы на подпрограммы.Переписывайте в начало программы условие и свою 
 /// фамилию.Все программы сделать в одном решении. Для решения задач используйте неизменяемые строки (string)
 /// </summary>
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] grades = new int[3];    // массив оценок
        public double avgGrade;              // средний балл
        // конструктор для создания обьекта Student
        public Student(string[] arr)
        {
            FirstName = arr[0];
            LastName = arr[1];
            for (var i = 0; i < 3; i++)
            {
                grades[i] = Convert.ToInt32(arr[i + 2]);
            }
            // считаю средний балл и округляю до одной цифры после запятой
            double a = (grades[0] + grades[1] + grades[2]) / 3;
            avgGrade = Math.Round(a, 1);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {grades[0]} {grades[1]} {grades[2]} средний балл - {avgGrade}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество участников: ");
            int cnt = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[cnt];   // создаю массив объектов
            string[] arrStr = new string[5];
            for (var i = 0; i < cnt;)
            {
                string str = Console.ReadLine();
                try
                {
                    arrStr = str.Split(' ');
                    students[i] = new Student(arrStr);
                    i++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("введите данные заного");
                }
            }
            // вызов функции сортировки
            Find3Worst(students, cnt);
            // показ массива - вывожу трех первых худших, а остальных проверяю, вдруг есть еще такие же
            for (var i = 0; i < cnt; i++)
            {
                Console.WriteLine("худшие ученики:");
                Console.WriteLine(students[0]);
                Console.WriteLine(students[1]);
                Console.WriteLine(students[2]);
                for (i = 3; i < students.Length; i++)
                {
                    // проверка на то что, если после третьего участника будут участники с таким же средним баллом,
                    // то нужно будет их всех вывести тоже
                    if (students[i].avgGrade == students[2].avgGrade)
                    {
                        Console.WriteLine(students[i]);
                    }
                }
            }
            Console.ReadLine();
        }

        // функция сортировки пузырьком
        public static Student[] Find3Worst(Student[] arr, int cnt)
        {
            Student temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].avgGrade > arr[j].avgGrade)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
