using System;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Oi meu nome Daniel e logo eu Daniel tenho vontade de codar muito" +
                " porque eu Daniel gosto de codar durante minha vida";

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"texto contem: {primeiroTexto.Length} caractares");

            primeiroTexto = primeiroTexto.Replace("Daniel", "1");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"texto contem: {primeiroTexto.Length} caractares");
            Console.ReadKey();
        }
    }
}
