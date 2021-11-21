using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParam(a, out S, out V);
            Console.WriteLine("Площадь куба");
            Console.WriteLine(S);
            Console.WriteLine("Объем куба");
            Console.WriteLine(V);
            Console.ReadKey();
        }
        static void GetParam(int a, out double S, out double V)
        {
            S = 6 * a * a;
            V = ((double)a * a * a);
        }

    }
}
