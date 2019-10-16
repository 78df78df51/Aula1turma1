using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCasa6
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "'Entre restos de fezes e bananas, eu comeria a sua banana.'";
            Console.WriteLine(primeiroTexto);
            Console.WriteLine("Vou modificar o texto acima trocando a palavra 'banana' por 'Laranjas'");
            Console.ReadKey();
            primeiroTexto = primeiroTexto.Replace("banana", "Laranja");
            Console.WriteLine(primeiroTexto);
            Console.ReadKey();
        }
    }
}
