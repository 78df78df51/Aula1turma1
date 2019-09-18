using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCasa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fala, qual é o seu nome?");
            var nome = Console.ReadLine();
            int idade;
            Console.Write("Quantos anos você tem?");
            int.TryParse(Console.ReadLine(), out idade);
            if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Parabéns {nome}, você já esta na fase adulta.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Calma {nome}, tudo ao seu tempo logo você terá 18 anos de idade.");
            }
            Console.ReadKey();
        }
    }
}
