using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" В семье n детей, каков шанс что среди них будет k мальчиков ? ");
            


            Double P, C, p, q, X, n, k;

            Console.WriteLine("Введите n  число детей в семье");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите k число мальчиков среди детей");
            k = Convert.ToDouble(Console.ReadLine());

            p = k / n;

            q = 1 - p;

            C = Prov(n) / Prov(k) * Prov(n - k);

            P = C * Math.Pow(p, k) * Math.Pow((1 - p), (n - k));

            X = p * 100;

            if (X < 0)
            {
                Console.WriteLine("Количество Детей не может быть меньше количества Мальчиков");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(Math.Round(X, 2) + "%");
                Console.ReadLine();
            }
        }
        private static double Prov(double n)
        {
            if (n == 0)
            {
                return 1;
            }

            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
}
