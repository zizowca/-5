using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 0 до 10");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0 && n > 10)
            {
                Console.WriteLine("Вы ввели неверное число");
            }
            //Если я правильно поняла условие, то массив нужно заполнить так - если сумму индексов строки и столбца четное число, то значение должно быть 1, если нечетная - 0
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int t = i + j;
                    if (t % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                    Console.Write("{0,4 }", array[i, j]);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
