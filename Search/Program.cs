using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {


        static void min(int curr, int count, double[] mas, ref double minimumValue, ref int minimumIndex)
        {
            minimumValue = mas[curr];
            for (int i = curr; i < count; i++)
                if (mas[i] > minimumValue)
                {
                    minimumValue = mas[i];
                    minimumIndex = i;
                }
        }

        double func1(double x)
        {
            return 2*x;
        }

        static bool Equals(double a, double b)
        {
            return a == b;
        }

        static void Main(string[] args)
        {
            double c = 3;
            double[] mas = { 1, 2, 54, 4, 6, 7, 8, 9, 10, 11, 12, 55, 55, 455, 3, 75, 85, 25, 15, 5, 4, 2, 5, 4, 6, 7, 8, 2, 1, 5, 4, 2, 5, 4, 6, 7, 8, 2, 1, 5, 35 };
          /* 
            double a = 0, b = mas.Length;
            double eps = 0.1;
            int n=5; //step
            double count = (b - a) / (n + 1);

            //for (double x = a; x < count; x += 1) 
             //   ;
            for (int i = 0; i < n; i++)
            {
                ;
            }
            */

            // Начало
            int a = 0;

            // Конец
            int b = mas.Length;

            // Количество участков
            int n = 10;

            // Шаг
            int dx = (b - a) / n;
            if (dx == 0)
                Console.WriteLine("Колличество участков слишком велико или граница интервала");

            // Находим минимум
            double yMin = F(mas,a);
            int xMin = a;
            bool find = false;
            for (int x = a + dx; x < b; x += dx)
            {
                double y = F(mas,x);
                if (y == c) // if (y < yMin)
                {
                    xMin = x;
                    yMin = y;
                    find = true;
                    break;
                }
            }

            Console.WriteLine("i={0}",xMin);
            Console.WriteLine("val={0}",yMin);
            Console.ReadKey();
        }

        private static double F(double[] m, int x)
        {
            return m[x];
        }

        /*private static double F(double x)
        {
            return Math.Sqrt(Math.Sin(x) + 2);
        }*/
    }
}
