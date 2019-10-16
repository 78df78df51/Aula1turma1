using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "";
            var countFind = 0;
            Console.WriteLine("Encontre a palavra de até 3 caractares:");
            var palavra = Console.ReadLine();

            for (int i = 1; i < (nome.Length -2); i++)
            {
                var palavraComparar = nome[i].ToString() +
                                      nome[i + 1].ToString() +
                                      nome[i + 2].ToString();

                if (palavra == palavraComparar)
                    countFind++;
                {

                }
            }
            Console.WriteLine($"Quantidade total de '{palavra}' {countFind}");
            Console.ReadKey();
        }
    }
}
