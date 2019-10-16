using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
	 class Program
	{
		//1º passo. isso é instancia
		static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
		static HoraDoShow horaDoShow = new HoraDoShow();
		static void Main(string[] args)
		{
			//documents.CriarPastaMeusDocumentos("nome");
			//documents.DeletarPastaMeusDocumentos("nome", true);
			//documents.ObterPastasDiretorioMeuDocumentos().ForEach(i => Console.WriteLine(i));

			//horaDoShow.Birllllllllll();
			Menu();
			Console.ReadKey();
		}
		public static void Menu()
		{
			var menuEscolhido = int.MinValue;

			while (menuEscolhido != 0)
			{
				Console.Clear();
				Console.WriteLine("Meus documentos");

				Console.WriteLine("Menu sistema");
				Console.WriteLine("1 - Criar pastas em meus Documentos");
				Console.WriteLine("2 - Deletar pastas em meu documentos");
				Console.WriteLine("3 - Listar meus documentos");
				Console.WriteLine("0 - Sair");

				menuEscolhido = int.Parse(Console.ReadLine());
			
				switch (menuEscolhido)
				{
					case 1:
						Console.WriteLine("Informe um nome para a pasta");
						var nomePasta = Console.ReadLine();
						documents.CriarPastaMeusDocumentos(nomePasta);
						break;
					case 2:
						Console.WriteLine("Informar o nome da pasta para excluir");
						var nomePasta2 = Console.ReadLine();
						documents.DeletarPastaMeusDocumentos(nomePasta2,true);
						break;
					case 3:
						documents.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
						break;
				}
			}
		}
	}
}
