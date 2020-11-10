using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace homework5_2
{
    static class Message
    {
        private static string content;
        public static string[] Words { get; set; }

        // в самом начале получаем на вход строку, распасиваем ее, и уже потом можем работать с ней как угодно
        public static string Content
        {
            get
            {
                return content;
            }
            // сделал в сеттере разбиение на строки что бы удобнее было
            set
            {
                Words = value.Split(' ');
                content = value;
            }
        }

        // а) Вывести те слова, которые содержат не более n букв
        public static string PrintSmallWords(int n)
        {
            string outStr = "";
            for (int i = 0; i < Words.Length; i++)
            {
                if (Words[i].Length <= n) outStr += Words[i] + " ";
            }
            return outStr;
        }

        // б) Вывести те слова, которые не заканчиваются на указанный символ
        public static string RemoveWords(char str)
        {
            string outStr = "";
            for (int i = 0; i < Words.Length; i++)
            {
                // если конец строки не совпадает с указанным, то добавляем его в выходную строку
                if (!Words[i].EndsWith(str.ToString())) outStr += Words[i] + " ";
            }
            return outStr;
        }

        // в) найти самое длинное слово
        public static string FindLongestWord()
        {
            // сортируем пузырьком, что бы в начале был наибольший элемент
            for (int i = 0; i < Words.Length; i++)
            {
                for (int j = i + 1; j < Words.Length; j++)
                {
                    if (Words[i].Length < Words[j].Length)
                    {
                        string temp = Words[i];
                        Words[i] = Words[j];
                        Words[j] = temp;
                    }
                }
            }
            return Words[0];    // возвращаем первый элемент
        }
        // г) сформировать строку из самых длинных слов(поскольку в предыдущем методе массив уже отсортировали, то если 
        // мы собираемся вызывать эти методы друг за другом, сортировать массив заного нет смысла)
        public static string buildLongString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Words[0]);  // для начала просто присваиваем самый первый элемент, потому что он точно больше всех
            for (int i = 1; i < Words.Length; i++)
            {
                // если последующие элементы будут такой же длины как и первый - тоже прицепляем их к строке
                if (Words[i].Length == Words[i - 1].Length) str.Append(Words[i]);
            }
            return str.ToString();
        }

        /// <summary>
        /// д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив 
        /// слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
        /// Здесь требуется использовать класс Dictionary.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FrequencyAnalysis(string str)
        {
            Dictionary<string, int> elems = new Dictionary<string, int>();
            string[] inWords = str.Split(' ');  // входной текст разбитый по словам
            int strYet;                         // выходное значение если такое слово уже было записано
            string outStr = "";                 // строка выхода

            // берем итое слово в тексте
            for (var i = 0; i < inWords.Length; i++)
            {
                // проверка на то, если такой элемент уже попадался и был записан в словарь               
                if (!elems.TryGetValue(inWords[i], out strYet))
                {
                    // крутим изначальную последовательность и считаем попадания в итое слово
                    int sum = 0;
                    sum = Words.Count(item => item == inWords[i]);
                    elems.Add(inWords[i], sum);
                    // если попадает хоть один раз то записываем в словарь
                    if (sum > 0)
                    {
                        outStr += $"элемент с именем: {Words[i]} попадается {sum} раз\n";
                    }
                }
            }
            if (outStr.Length > 0) return outStr; else return "совпадений нет";
        }
    }
}
