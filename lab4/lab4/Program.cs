using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        const double StartX1 = 1;
        const double StartX2 = 1;
        const double dX = 0.7;

        static double Function(double x1, double x2) { return Math.Cos(Math.Sqrt(x2)+34*Math.Sin(x1))- 4*Math.Sin(x2); }
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            double x1 = StartX1;
            double x2 = StartX2;
            double k = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                arr[i] = Function(x1 , x2);
                x1 += dX;
                x2 += dX;
            }

            Array.Sort(arr); Array.Reverse(arr);

            Console.WriteLine("Вiдсортованi за спаданням значення масиву: ");

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++) {
                Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);
            }

            double aMin = arr[arr.GetUpperBound(0)];
            double aMax = arr[arr.GetLowerBound(0)];
            double aAvg = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                aAvg += arr[i];
            }
            aAvg = aAvg / arr.GetLength(0);
            for (int i=0; i<=9; i++)
            {
                if (arr[i] > aAvg)
                    k++;

            }

            Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
            Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
            Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
            Console.WriteLine("Кiлькiсть елементiв масиву, бiльших за середнє значення: " + k);

            Console.ReadKey(true);
        }
    }
}
