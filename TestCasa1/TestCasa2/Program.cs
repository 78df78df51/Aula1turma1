using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCasa2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Olá, Blz?!";
            Console.WriteLine(nome);
            Console.ReadKey();
            Nomes();
            Console.ReadKey();
        }
        private static void Nomes()
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine($"Bem Vindo mano(a) {nome}");
        }
    }
}
