using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoOWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (count < 1000)
            {
                Console.WriteLine($"Número:{count}");
                count+=5;
            }

            Console.WriteLine("Terminou o Loop");
            Console.ReadKey();
        }
    }
}
