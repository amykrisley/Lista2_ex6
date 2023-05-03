using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, p, r;

            Console.Write("Qual é o seu peso(em kilos): ");
            p = double.Parse(Console.ReadLine());

            Console.Write("Qual é a sua altura(em metros): ");
            h = double.Parse(Console.ReadLine());

            r = p / Math.Pow(h, 2);

            if (r < 20)
                Console.WriteLine("Abaixo do peso");
            else
                if (r < 25)
                Console.WriteLine("Peso ideal");
            else
                Console.WriteLine("Acima do peso");
        }
    }
}
