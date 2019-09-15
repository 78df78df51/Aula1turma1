using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCasa7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto");
            var text = Console.ReadLine();


            var quantidadedeA = text.Split('a').Length - 1;
            Console.WriteLine("quantidade de A " + quantidadedeA);

            var quantidadedeE = text.Split('e').Length - 1;
            Console.WriteLine("quantidade de E " + quantidadedeE);

            var quantidadedeI = text.Split('i').Length - 1;
            Console.WriteLine("quantidade de I " + quantidadedeI);

            var quantidadedeO = text.Split('o').Length - 1;
            Console.WriteLine("quantidade de O " + quantidadedeO);

            var quantidadedeU = text.Split('u').Length - 1;
            Console.WriteLine("quantidade de U " + quantidadedeU);

            Console.ReadKey();
        }
    }
}
