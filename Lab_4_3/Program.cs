using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 4.2");
            Console.WriteLine();
            Console.WriteLine("Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально");
            Console.WriteLine("возможное количество квадратов со стороной C (без наложений). Найти количество квадратов,");
            Console.WriteLine("размещенных на прямоугольнике. Операции умножения и деления не использовать.");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ВВЕДИТЕ ВЫСОТУ ПРЯМОУГОЛЬНИКА, (A)");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("ВВЕДИТЕ ШИРИНУ ПРЯМОУГОЛЬНИКА, (B)");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("ВВЕДИТЕ ДЛИНУ СТОРОНЫ КВАДРАТА, (C)");
            int c = Convert.ToInt32(Console.ReadLine());
            int m = c; // Принимается длина стороны квадрата, которая должна уместиться по высоте
            int n = c; // Принимается длина стороны квадрата, которая должна уместиться по ширине
            int p = 0; // Счетчик квадратов
            while (m <= a)
            {
                while (n <= b)
                {
                    p++;
                    n += c;
                }
                m += c;
                n = c; // Обнуляем сумму длин сторон уместившихся квадратов, т.к. переходим на новую координату высоты
            }
            Console.WriteLine();
            Console.WriteLine(">> КОЛИЧЕСТВО РАЗМЕЩАЕМЫХ ФИГУР {0}х{0} В ПРЯМОУГОЛЬНИКЕ {1}х{2}: {3}", c, a, b, p);
            Console.ReadKey();
        }
    }
}
