using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCasa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra: ");
            var text = Console.ReadLine();
            Console.WriteLine($"o primeiro caracter da palavra é a letra: {text[0]}");
            Console.WriteLine($"primeiro caracter da palavra é igual: {text[text.Length - 2]}");
            Console.WriteLine($"o ultimo caracter desta palavra é a letra {text[text.Length - 1]}");
            Console.ReadKey();
        }
    }
}
