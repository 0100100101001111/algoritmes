using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab2
{
    class Program
    {
        private static void MyFunction(double R, double X, double Y)
        {
            if ((X <= 0 && Y <= 0 && ((X + Y) >= -2*R)) || (X <= 2*R && X >= 0 && Y <= 2*R && Y >= 0 && (Math.Pow(X, 2) + Math.Pow(Y, 2) >= Math.Pow(R, 2))))
            {
                Console.WriteLine("\nТочка попадает в заштрихованную область!");
            }
            else
            {
                Console.WriteLine("\nТочка не попадает в заштрихованную область!");
            }
        }
        static void Main(string[] args)
        {
            // Инициализация переменных
            double Radius = 0, varX = 0, varY = 0;
            // Ввод значения переменной Radius с обработкой исключений
            do
            {
                Console.Write("Введите значение R: ");
                if (!(Double.TryParse(Console.ReadLine(), out Radius)))
                {
                    Console.WriteLine("\nВведено не числовое значение!");
                    continue;
                }
                else if (Radius > 0)
                    break;
                else
                    Console.WriteLine("\nВведено значение R вне допустимого предела (R > 0).");
            } while (true);
            // Ввод значения переменной varX с обработкой исключений
            do
            {
                Console.Write("Введите значение X: ");
                if (!(Double.TryParse(Console.ReadLine(), out varX)))
                {
                    Console.WriteLine("\nВведено не числовое значение!");
                    continue;
                }
                else
                    break;                                
            } while (true);
            // Ввод значения переменной varY с обработкой исключений
            do
            {
                Console.Write("Введите значение Y: ");
                if (!(Double.TryParse(Console.ReadLine(), out varY)))
                {
                    Console.WriteLine("\nВведено не числовое значение!");
                    continue;
                }
                else
                    break;
            } while (true);
            // Проверка выполнения условия и вывод результата
            MyFunction(Radius, varX, varY);
            Console.ReadKey();
        }
    }
}
