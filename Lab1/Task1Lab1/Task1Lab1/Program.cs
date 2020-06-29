using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab1
{
    class Program
    {
        static double MyFunction(double R, double X)
        {
            if (X >= -3 && X < -1)
                return (-X - 1);
            else if (X >= -1 && X < 3 - R)
                return 0;
            else if (X >= 3 - R && X < 3 + R)
                return Math.Sqrt(Math.Pow(R, 2) - Math.Pow((X - 3), 2));
            else if (X >= 3 + R && X <= 7)
                return (-0.5 * X + 2.5);
            else
                return 0;
        }

        static void Main(string[] args)
        {
            // Инициализация переменных
            double Radius = 0, varX = 0;
            // Ввод значения переменной R с обработкой исключений
            do
            {
                Console.Write("Введите значение R (от 0 до 2): ");
                if (!(Double.TryParse(Console.ReadLine(), out Radius)))
                {
                    Console.WriteLine("\nВведено не числовое значение!");
                    continue;
                }
                if (Radius >= 0 && Radius <= 2)
                    break;
                else
                    Console.WriteLine("\nВведено значение R вне допустимого предела.");
            } while (true);
            // Ввод значения переменной varX с обработкой исключений
            do
            {
                Console.Write("Введите значение X (от -3 до 7): ");
                if (!(Double.TryParse(Console.ReadLine(), out varX)))
                {
                    Console.WriteLine("\nВведено не числовое значение!");
                    continue;
                }
                if (varX >= -3 && varX <= 7)
                    break;
                else
                    Console.WriteLine("\nВведено значение X вне допустимого предела.");
            } while (true);
            // Вывод результата расчета на экран
            Console.WriteLine($"\nR = {Radius}\nF({varX}) =  " + MyFunction(Radius, varX) + "\n");
        }
    }
}
