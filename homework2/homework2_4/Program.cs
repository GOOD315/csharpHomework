using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_4
{
    class Program
    {
        // Бабошин
        /* 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, 
          если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки 
          логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или 
          не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        */
        static void Main(string[] args)
        {
            if (Authorization()) Console.WriteLine("Доступ разрешен"); else Console.WriteLine("Доступ запрещен");
            Console.ReadLine();
        }

        static Boolean Authorization()
        {
            Int32 n = 0;
            while (n < 3)
            {
                Console.Write("Введите логин: ");
                String login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                String password = Console.ReadLine();
                if ((login == "root") && (password == "GeekBrains")) return true;
                Console.WriteLine("Данные неверны, введите еще раз");
                n++;
            }
            return false;
        }
    }
}
