using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe um minitexto");
            var text = Console.ReadLine();
            Console.WriteLine($"Tamanho do texto digtiaod {text.Length}");
            Console.ReadKey();
        }
    }
}
