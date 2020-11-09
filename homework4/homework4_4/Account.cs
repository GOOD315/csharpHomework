using System;
using System.IO;

namespace homework4_4
{
    struct Account
    {
        string login;
        string password;
        public Account(string file)
        {
            login = "";
            password = "";
            // изначальная проверка на то есть ли вообще такой файл
            if (File.Exists("file.txt"))
            {
                StreamReader sr = new StreamReader(file);
                string str = sr.ReadLine();
                string[] words = str.Split(':'); // принимает на вход первую строку в виде "login:password"
                // пытаюсь присивоить логин и пароль, если не получилось то выдаю месседж
                try
                {
                    login = words[0];
                    password = words[1];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else throw new Exception("Не удалось считать логин и пароль из файла");
        }
    }
}
