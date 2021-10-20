using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 4.1");
            Console.WriteLine();
            Console.WriteLine("Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую");
            Console.WriteLine("формулу: N^2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить");
            Console.WriteLine("текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО N > 0");
            // Запрашиваем ввод числа
            int m = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            Console.WriteLine();
            // Проверка на положительность введенного числа
            if (m < 0)
            {
                Console.WriteLine(">> ВВЕДЕННОЕ ЧИСЛО МЕНЬШЕ 0");
            }
            else
            {
                for (int i = 1; i <= m; i++)
                {
                    n += 2 * i - 1;
                    Console.WriteLine(">> КВАДРАТ ЧИСЛА {0} РАВЕН {1}", i, n);
                }
            }
            Console.ReadKey();
        }
    }
}
