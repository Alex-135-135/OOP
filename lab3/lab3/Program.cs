using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static double Function(double x1, double x2) { return Math.Cos(x1-Math.Pow(x2,2))+31.55*x2*Math.Pow(x1,2); }
        static void Main(string[] args)
        {
        StartOfCalculations:

            Console.Write("Введiть початок вiдрiзку iнтегрування a: "); string sa = Console.ReadLine(); double a = double.Parse(sa);

            Console.Write("Введiть кiнець вiдрiзку iнтегрування b: "); string sb = Console.ReadLine(); double b = double.Parse(sb);

            Console.Write("Введiть кiлькiсть дiлянок n: "); string sn = Console.ReadLine(); double n = double.Parse(sn);

            double dx = (b - a) / n; double y1, y2; double x1, x2; double Intgrl = 0;


            for (int i = 0; i < n; i++)
            {
                x1 = a + i * dx;
                x2 = x1 + dx;
                if (x1 < b) { 
                y1 = Function(x1, x2);
                y2 = Function(x1, x2);

                // Обчислення інтегралу методом центральних прямокутників  
                Intgrl += (y1 + y2) * dx;
                    }   
                 } 

                Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:0.0000}", a, b, Intgrl);
            Console.Write("Повторити розрахунок (y - так) ? "); ConsoleKeyInfo pressedKey = Console.ReadKey(); Console.WriteLine(); if (pressedKey.Key == ConsoleKey.Y) { Console.WriteLine(); goto StartOfCalculations; }
        }
    }
}
