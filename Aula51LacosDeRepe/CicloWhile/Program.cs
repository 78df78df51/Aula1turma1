using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome =string.Empty;

            //while (AskToContinue() == 1)
            //{
            Console.ReadKey();
                nome = AskToNome();
                int idade = de();       
            //}

            Console.WriteLine($"Suas informações: nome: {nome} e sua idade: {idade}");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("-----Bem Vindo----");
            Console.WriteLine("------------------");
        }
        /// <summary>
        /// Metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido.</returns>\
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
      
        /// <summary>
        /// metodo qual sua idade
        /// </summary>
        private static int de()
        {
           //console.WriteLine("Você tem mais de 18 anos?");
            int Idade2;
            Console.Write("Informe sua idade:");
            int.TryParse(Console.ReadLine(), out Idade2);
             if (Idade2 >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso permitido, endoidaaaaaaaa!!!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Espere mais alguns anos");
            }
            return Idade2;

        }
        //private static int AskToAge()
        //{
        //    Console.WriteLine("Qual sua idade?");
        //    int idade = int.Parse(Console.ReadLine());

        //    if (idade >= 18)
        //        Console.WriteLine("Bora beber, sextoooouuuuuuuu !!!!!!!!!!");
        //    else
        //        Console.WriteLine("Putz, talvez ano que vem");
        //    return idade;
        //}
        /// <summary>
        ///   Metodo para perguntar o nome
        /// </summary>
        /// <returns></returns>
        private static string AskToNome()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();
        }
    }
    
}
