using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDeDecimais();
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 17));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MM/dd")));
        }
        /// <summary>
        /// Mostra lista de String definidas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");


            minhaLista.ForEach(i => Console.WriteLine(i));
        }
        /// <summary>
        /// Metodo que mostra meus numeros inteiros
        /// </summary>
        private static void NumInt()
        {
            var numInt = new List<int>();

            numInt.Add(1);
            numInt.Add(2);
            numInt.Add(3);

            numInt.ForEach(i => Console.WriteLine(i));
        }
        /// <summary>
        /// minha lista de numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();
            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " | " + FormataNumeroDecimalEmDolar(meuDecimal) +
               FormataNumeroDecimalEmEuro(meuDecimal) + " | " + FormataNumeroDecimalEmYen(meuDecimal) + " | " + FormataNumeroDecimalEmBitCoin(meuDecimal)));
        }/// <summary>
        /// converte reaispara dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.50).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$"," Dolar ");
        }
        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")).Replace("€", " Euro ");
        }
        private static string FormataNumeroDecimalEmYen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP")).Replace("¥", " Euro ");
        }
        private static string FormataNumeroDecimalEmBitCoin(double meuNumero)
        {
            return (meuNumero / 41997.32).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", " BTC ");
        }

    }
}
