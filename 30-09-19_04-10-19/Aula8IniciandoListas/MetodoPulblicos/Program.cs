using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoPulblicos
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static void ConversorMonetarioSis()
        {
            Console.WriteLine("Sistema conversor de moedas");
            Console.WriteLine("Informe valor a ser convertido");

            //Aqui vai ser definido o valor a ser convertido
            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão monetária");
            Console.WriteLine("DOLAR, EURO, YEN, BTC");

            //Aqui sera escolhida a moeda para converter o valor informado.
            var moedaAlvoParaConverter = Console.ReadLine().ToUpper();

            //Aqui executa o metodo de conversao do valor informado, exibindo o valor
            // de acordo com a moeda escolhida

        }
    }
}
