using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 4.2");
            Console.WriteLine();
            Console.WriteLine("Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных");
            Console.WriteLine("или количество отрицательных. Последовательность потенциально не ограничена, окончанием последо-");
            Console.WriteLine("вательности служит число 0.");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            int m = 0;
            int plus = 0; // Число положительных чисел
            int minus = 0; // Число отрицательных чисел
            do
            {
                Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
                int n = Convert.ToInt32(Console.ReadLine());
                m = n;
                n = (m > 0) ? plus++ : minus++; // Использую уже созданную раннее переменную n внутри цикла для выполнения тернарного оператора
                if (m == 0) // Тернарный оператор прибавляет единицу к количеству отрицательных чисел при вводе 0, т.к.при условии "0 > 0?" результат false, убираем единицу
                {
                    minus--;
                }
            } while (m != 0);
            #region Комбинации выводов по итогу программы
            if (plus > minus)
            {
                Console.WriteLine();
                Console.WriteLine(">> ПОЛОЖИТЕЛЬНЫХ ЧИСЕЛ БОЛЬШЕ (ПОЛОЖИТЕЛЬНЫХ: {0}, ОТРИЦАТЕЛЬНЫХ: {1})", plus, minus);
            }
            else
            {
                if (plus < minus)
                {
                    Console.WriteLine();
                    Console.WriteLine(">> ОТРИЦАТЕЛЬНЫХ ЧИСЕЛ БОЛЬШЕ (ПОЛОЖИТЕЛЬНЫХ: {0}, ОТРИЦАТЕЛЬНЫХ: {1})", plus, minus);
                }
                else
                {
                    if (plus == 0 && minus == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine(">> ВВЕДЕН 0");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(">> ПОЛОЖИТЕЛЬНЫХ И ОТРИЦАТЕЛЬНЫХ ЧИСЕЛ РАВНОЕ КОЛИЧЕСТВО (ПО {0})", plus);
                    }
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}
