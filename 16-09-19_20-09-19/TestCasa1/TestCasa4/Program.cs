using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCasa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, me informe um texto pequeno para que eu possa contar os caracteres para vc:");
            var texto = Console.ReadLine();
            Console.WriteLine($"Tamanho total de caracteres digitado foi de {texto.Length}");
            Console.ReadKey();
        }
    }
}
