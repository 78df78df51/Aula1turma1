using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            int Idade2;
            Console.Write("Informe sua idade:");
            int.TryParse(Console.ReadLine(), out Idade2);
            if (Idade2 >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
            }
            Console.ReadKey();
        }
        
    }
}
