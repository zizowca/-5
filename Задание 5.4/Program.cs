using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]); // выводим исходный вид массива
            }
            Console.WriteLine();
            int Sum = 0;
            for (int i=0; i <array.Length; i++)
            {
                int t = array[i];
                if (t % 2 == 1 && t > 0)
                {
                    Sum++;
                    
                }
            }
            Console.WriteLine("Количество нечетных чисел в массиве больше ноля = {0} ", Sum);
            /*посчитать нечетные числа > 0 на четных индексах у меня пока не получилось, пробовала в условии писать for (int i=0; i <array.Length && i%2==0; i++),
           но сумма в итоге не считается и выходит просто присвоенное ей значение 0*/

            Console.ReadKey();
        }
    }
}
