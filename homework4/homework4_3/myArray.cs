using System;
using System.Collections.Generic;
using System.Linq;

namespace homework4_3_lib
{
    public class myArray
    {
        int[] data;
        public int Length { get; set; }
        public int Step { get; set; }
        // получаю на вход первое значение, количество элементов и шаг, и строю массив
        public myArray(int firstNum, int count, int step)
        {
            Step = step;
            Length = count;
            data = new int[Length];
            data[0] = firstNum;
            // заполнить массив элементами
            for (var i = 1; i < Length; i++)
            {
                data[i] = data[i - 1] + step;
            }
        }
        public myArray()
        {

        }
        public int this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        // Свойство которое возвращает сумму
        public int Sum
        {
            get
            {
                int sum = 0;
                for (var i = 1; i < Length; i++)
                {
                    sum += data[i];
                }
                return sum;
            }
        }
        // сразу получаю инвертированный массив
        public myArray Inverse()
        {
            return new myArray(-data[0], Length, -Step);
        }

        // то же самое
        public myArray Multi(int multiplier)
        {
            return new myArray(data[0] * multiplier, Length, Step * multiplier);
        }

        /// <summary>
        /// нахожу максимальный элемент массива и сравниваю количество совпадений каждого из элементов массива
        /// максимальному значению
        /// правда оно работает только в случае, когда все элементы массива равны нулю(0 10 0)
        /// для другого случая число будет всегда = 1
        /// </summary>
        /// <returns></returns>
        public int FindMax()
        {
            int max = data.Max();
            return data.Count(item => item == max);
        }

        /// <summary>
        /// ищу все одинаковые элементы и записываю их в словарь, 
        /// где "key = цифра этого элемента", "value = количество таких элементов"
        /// </summary>
        public Dictionary<int, int> ElementFrequency()
        {
            Dictionary<int, int> equalNumbers = new Dictionary<int, int>();
            int dicBool;

            for (var i = 0; i < Length; i++)
            {
                // проверка на то, что такой элемент массива уже был посчитан и записан в словарь                
                if (!equalNumbers.TryGetValue(data[i], out dicBool))
                {
                    int num = data[i];
                    int sum = data.Count(item => item == num);
                    equalNumbers.Add(num, sum);
                }

            }
            return equalNumbers;
        }
        public override string ToString()
        {
            string str = "";
            for (var i = 0; i < data.Length; i++)
            {
                str += data[i] + "\n";
            }
            return str;
        }

    }
}
