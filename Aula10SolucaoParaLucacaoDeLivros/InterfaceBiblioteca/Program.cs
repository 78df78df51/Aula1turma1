using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
namespace InterfaceBiblioteca
{
	class Program
    {
		////instarciar "carregar na memoria" nosso controlador dos usuarios
		static LivrosController livrosController = new LivrosController();
        //instarciar "carregar na memoria" nosso controlador dos usuarios
        static UsuarioController usuarioController = new UsuarioController();
		static void Main(string[] args)
        {
            Console.WriteLine("__________________Sistema de locação de livro 2.0__________________");
            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos, tente novamente por favor");
            Console.Clear();
			 MostraMenuSistema();
			Console.ReadKey();
        }
        private static void MostraMenuSistema()
        {
			//aqui vamos pegar numero digitado e executar proxima funcao
			var opcao = "1";
				while (opcao != "0") { 
					Console.Clear();
					Console.WriteLine("Sistema de locação de livro 2.0");
			
					Console.WriteLine("Menu sistema");
					Console.WriteLine("1 - Cadastrar Livros");
					Console.WriteLine("2 - Listar Livros");
					Console.WriteLine("3 - Remover Livros");
					Console.WriteLine("4 - Atualizar dados dos Livros");
				    Console.WriteLine("5 - Cadastrar usuário");
				    Console.WriteLine("6 - Listar usuários");
					Console.WriteLine("7 - Trocar usuário");
					Console.WriteLine("8 - Remover usuário");
					Console.WriteLine("0 - Sair");

					opcao = Console.ReadLine();
				switch (opcao)
				{
					case "1":
						CadastrarLivro();
						break;
					case "2":
						ListarLivros();
						break;
					case "3":
						RemoverLivro();
						break;
					case "4":
						AtualizarLivro();
						break;
					case "5":
						CadastrarUsuario();
						break;
					case "6":
						ListarUsuarios();
						break;
					case "7":
						Console.Clear();
						while (!RealizaLoginSistema())
							Console.WriteLine("Login e senha inválidos");
						Console.Clear();
						break;
					case "8":
						RemoverUsuario();
						break;
					case "0":
						Console.Clear();
						Console.WriteLine("Saindo... até a próxima ");
						break;
				}
			}
        }
		private static void CadastrarLivro()
		{
			Console.WriteLine("Cadastrar  livro no sistema:");
			Console.WriteLine("Nome do livro para ser cadastrado");
			var nomeDoLivro = Console.ReadLine();
			var livroNome = livrosController.InserirLivros(new Livros()
			{
				Nome = nomeDoLivro
			});
			if (livroNome)
				Console.WriteLine("Livro cadastrado com sucesso!");
			else
				Console.WriteLine("Livro não cadastrado");
			Console.ReadKey();
		}
		private static void ListarLivros()
		{
			livrosController.GetLivros().ToList().ForEach(item => Console.WriteLine($"ID do livro:{item.Id}, Nome do livro:{item.Nome}"));
			Console.ReadKey();
		}
		private static void RemoverLivro()
		{
			Console.WriteLine("Remover um livro do sistema");
			ListarLivros();
			Console.WriteLine("Informe o ID para desativar do sistema");
			var livroId = int.Parse(Console.ReadLine());

			var livroRemover = livrosController.RemoverLivros(livroId);
			if (livroRemover)
				Console.WriteLine("Livro removido com sucesso");
			else
				Console.WriteLine("ID do livro incorreto");
			Console.ReadKey();
		}
		private static void AtualizarLivro()
		{
			Console.WriteLine("---Atualizar Dados de Livro---");
			ListarLivros();
			Console.WriteLine("Informe o Id do Livro");
			var livroId = int.Parse(Console.ReadLine());
			var livro = livrosController.GetLivros().FirstOrDefault(x => x.Id == livroId);
			if (livro == null)
			{
				Console.WriteLine("Id informado é inválido");
				return;
			}
			Console.WriteLine("Informe o nome do livro: ");
			livro.Nome = Console.ReadLine();

			var resultado = livrosController.AtualizarLivros(livro);

			if(resultado)
				Console.WriteLine("Sucesso!!!!!!!!!!!!");
			else
				Console.WriteLine("Erro!!!!!!");
			Console.ReadKey();
		}
		public static void CadastrarUsuario()
		{
			Console.WriteLine("Cadastrar novo usuario no sistema:");
			Console.WriteLine("Login do usuario para cadastro");
			var loginDoUsuario = Console.ReadLine();
			Console.WriteLine("Senha do usuario para cadastro");
			var senhaDoUsuario = Console.ReadLine();

			var resultado = usuarioController.AdicionarUsuario(new Usuario()
			{ Login = loginDoUsuario, Senha = senhaDoUsuario, DataCriacao = DateTime.Now });
			if (resultado)
				Console.WriteLine("usuario cadastrado com sucesso!");
			else
				Console.WriteLine("Errou, tente novamente!!!!!!!");
			Console.ReadKey();
		}
		private static void ListarUsuarios()
		{
			usuarioController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id é:{i.Id}, com o Login: {i.Login}."));
			Console.ReadKey();
		}
		private static bool RealizaLoginSistema()
		{
			Console.WriteLine(@"___________________________________________________________________");
			Console.WriteLine(@"__________________Bem vindo a Biblioteca da HBSIS__________________");
			Console.ReadKey();
			Console.WriteLine(@"___________________________________________________________________");
			Console.WriteLine(@"__________________Informe seu Login e senha para acessar___________");
			Console.ReadKey();

			Console.WriteLine("");
			Console.WriteLine("__________________Login: ");
			var loginDoUsuario = Console.ReadLine();

			Console.WriteLine("__________________Senha: ");
			var senhaDoUsuario = Console.ReadLine();

			Console.Clear();
			return usuarioController.LoginSistema(new Usuario()
			{
				Login = loginDoUsuario,
				Senha = senhaDoUsuario
			});
		}
		private static void RemoverUsuario(){
			Console.WriteLine("Remover um usuario pelo ID no sistema");
			ListarUsuarios();
			Console.WriteLine("Informe o ID para desativar do sistema");
			var usuarioID = int.Parse(Console.ReadLine());

			var usuarioRemover = usuarioController.RemoverUsuariosPorID(usuarioID);
			if(usuarioRemover)
			Console.WriteLine("Usuarios desativado com sucesso");
			else
				Console.WriteLine("Usuario não removido, tente outra vez");
			Console.ReadKey();
		}
    }
}

