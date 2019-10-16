using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe um valor a ser convertido:");
            Console.Write("R$");

            var valorASerConvertido = double.Parse(Console.ReadLine());


            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que converte moeda em real para um alvo espacificado
        /// para converter digite os alvos:
        /// -"EURO"
        /// -"YEN"
        /// -"BTC"
        /// -"DOLAR"
        /// </summary>
        /// <param name="minhaMoeda"></param>moeda em valor real
        /// <param name="moedaAlvo"></param>alvo em que a minha moeda sra convertida
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumeroDecBitcoin(minhaMoeda));
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// metodo que converte meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero"></param>meu numero em reais
        /// <returns></returns>retorna o valor formatado em dolar

        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

        }
        private static string FormataNumeroDecEuro(double meuNumero)
        {
            return (meuNumero / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("de-DE")).Replace("$", "Euro ");
        }
        private static string FormataNumeroDecYen(double meuNumero)
        {
            return (meuNumero / 0.38).ToString("C5", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        private static string FormataNumeroDecBitcoin(double meuNumero)
        {
            return (meuNumero / 41997.32).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC ");
        }
    }
}

