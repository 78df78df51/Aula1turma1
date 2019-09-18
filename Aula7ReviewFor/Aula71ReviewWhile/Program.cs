using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula71ReviewWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto: ");
            var texto = Console.ReadLine();
            var count = 0;

            while (count < texto.Length)
            {
                Console.WriteLine(texto[count]);
                count++;
            }
        }
    }
}
