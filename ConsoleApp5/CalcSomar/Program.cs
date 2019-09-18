using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.Write("Informe o 1 numero - >");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o 2 numero - >");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.Write(resultado);
            Console.ReadKey();
        }
    }
}
