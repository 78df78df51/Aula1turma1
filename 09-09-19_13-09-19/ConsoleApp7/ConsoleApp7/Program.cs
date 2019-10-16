using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o livro a ser consultado:");
            var numeroDoLivro = Console.ReadLine();
            /* PARTE DO CODIGO QUE RECEBE AS INFORMAÇÕES */
            if (numeroDoLivro == "89562")
            {
                Console.WriteLine("Livro Indisponivel!!!!!");
                return;
            } else    {
                Console.WriteLine("Deseja alocar o livro" + ("(1)sim (2)não"));
                var resposta = Console.ReadLine();
                if(resposta == "1")
                {
                    Console.WriteLine("Livro alugado.");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
