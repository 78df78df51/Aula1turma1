using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "BEM VINDO";
            Console.WriteLine(nome);
            Console.ReadKey();
            AskToNome();
            Console.ReadKey();

        }
        private static void AskToNome()
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine($"seu nome é : {nome}");
        }
    }
}
