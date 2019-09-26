using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryVendas;
using LibraryVendas.Controller;

namespace Infor
{
	class Program
	{
       static VendaController vendaController = new VendaController();
        //exibir informações
        static void Main(string[] args)
		{

            Console.WriteLine("Bem vindo ao sistema de carro HBSIS - Projeto Padawan");
            MostrarMenu();

            Console.ReadKey();
            /* vendaController.emitir(); */
        }
        public static void MostrarMenu()
        {
            var menuEscolhido = int.MinValue;
            while (menuEscolhido != 0)
            {
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar Usuários");
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch 
                { 
                    case 1:
                        break;
                    default:
                        break;
                }
            }
        }
	}
}
