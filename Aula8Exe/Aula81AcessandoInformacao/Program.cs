using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace Aula81AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Aula8Exe.Program.arvore();
            Console.ReadKey();*/
            //CalcularArea();
            MenuSistema();
        }
        private static void MenuSistema()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções do menu: ");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostra animação");
            Console.WriteLine("3 - Visualizar lista de cervejas");
            Console.WriteLine("4 - Sair do sistema");
            Console.WriteLine();


            var menuEscolhido = int.Parse(Console.ReadLine());
            
            switch (menuEscolhido)
            {
                case 1: { CalcularArea(); MenuSistema(); } break;
                case 2: { Aula8Exe.Program.arvore(); Console.ReadKey(); MenuSistema(); } break;
                case 3: { Aula8Exe.Program.cerveja(); MenuSistema(); } break;        
                case 4: { Console.WriteLine("Saindo ... aperte Enter"); Console.ReadKey(); return; }
                default:
                    break;
            }
            
        }
        public static void CalcularArea()
        {
            Console.WriteLine("Informa o lado do quadrado");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var biblbiotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha área é {biblbiotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}"  );
            Console.ReadKey();
        }
    }
}
