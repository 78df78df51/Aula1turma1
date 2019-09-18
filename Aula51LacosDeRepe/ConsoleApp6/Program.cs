using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Entre restos de fezes e bananas, eu comeria a sua banana.";
            primeiroTexto = primeiroTexto.Replace("banana", "Laranja");
            Console.WriteLine(primeiroTexto);
            Console.ReadKey();
        }
    }
}
