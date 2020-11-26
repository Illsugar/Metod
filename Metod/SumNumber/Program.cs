using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            string oddnum = ""; 

            do // выполнять
            {
                Console.WriteLine("Введите число");
                int.TryParse(Console.ReadLine(), out num);
                if (num > 0 && num % 2 != 0) //проверка на положительность и нечётность
                {
                    sum += num;
                    oddnum += $"{num }";
                }
            }
            while (num != 0); //пока num не 0

            Console.WriteLine($"Нечётные числа: {oddnum}");
            Console.WriteLine($"Сумма нечётных чисел равна: {sum}");
            Console.ReadLine();
        }
    }
}
