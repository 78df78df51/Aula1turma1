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
        static LivrosController livrosController = new LivrosController();
        //instarciar "carregar na memoria" nosso controlador dos usuarios
        static UsuarioController Usuario = new UsuarioController();
		

		static void Main(string[] args)
        {
            Console.WriteLine("__________________Sistema de locação de livro 1.0__________________");
            Console.ReadKey();
            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");
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
			    Console.WriteLine("Sistema de locação de livro 1.0");
			
				Console.WriteLine("Menu sistema");
				Console.WriteLine("1 - Listar usuários");
				Console.WriteLine("2 - Listar Livros");
				Console.WriteLine("3 - Cadastrar Livro");
				Console.WriteLine("4 - Trocar usuário");
				Console.WriteLine("5 - Cadastrar usuário");
				Console.WriteLine("6 - Remover usuário");
				Console.WriteLine("7 - Remover livro");
				Console.WriteLine("0 - Sair");

				opcao = Console.ReadLine();
				switch (opcao)
				{
					case "1":
						MostrarUsuarios();
						break;
					case "2":
						ListarLivros();
						break;
					case "3":
						AdicionarLivro();
						break;
					case "4":
						Console.ReadKey();
						while (!RealizaLoginSistema())
							Console.WriteLine("Login e senha inválidos");
						Console.Clear();
						break;
					case "5":
						AdicionarUsuario();
						break;
					case "6":
						RemoverUsuarioPeloID();
						break;
					case "7":
						RemoverLivro();
						break;
					case "0":
						Console.Clear();
						Console.WriteLine("Saindo... até a próxima ");
						break;
				}
			}

        }
		/// <summary>
		/// Metodo que realiza os procedimentos completo de login dentro do sistema
		/// como solicitaçao de login e senha
		/// </summary>
		/// <returns>Retorna verdadeiro quando o login e senha informdas estiverem corretas</returns>
		private static void RemoverLivro()
		{
			Console.WriteLine("Remover um livro do sistema");
			MostrarLivros();
			Console.WriteLine("Informe o ID para desativar do sistema");
			var livroId = int.Parse(Console.ReadLine());

			livrosController.RemoverLivroPorID(livroId);

			Console.WriteLine("Livro removido com sucesso");
			Console.ReadKey();

		}
		private static void RemoverUsuarioPeloID(){
			Console.WriteLine("Remover um usuario pelo ID no sistema");
			MostrarUsuarios();
			Console.WriteLine("Informe o ID para desativar do sistema");
			var usuarioID = int.Parse(Console.ReadLine());
			Usuario.RemoverUsuariosPorID(usuarioID);
			Console.WriteLine("Usuarios desativado com sucesso");
			Console.ReadKey();
		}
		private static void AdicionarLivro()
		{
			//identificamos uqe o mesmo esta na parte de cadastro de livros do sistema
			Console.WriteLine("Cadastrar  livro no sistema:");
			//informamos que para dar continuidade ele deve informar um nome para o livro
			Console.WriteLine("Nome do livro para cadastro");
			//obtemos esta informação do usuario
			var nomeDoLivro = Console.ReadLine();
			//"livroController" livros controle e nosso "objeto" em memoria
			//com isso temos disponivel nele ferramentas que nos ajudam a realizar as tarefas
			//como adicionar um item a nossa lista de livros

			livrosController.AdicionarLivro(new Livros()
			{
				//Aqui "Atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
				//com o sinal de panes "=" temos atribuição, passagem de valor
				Nome = nomeDoLivro
			});
			//indico que finalizamos o processo de cadastro do livro, assim o usuario já sabe
			//que o mesmo foi realizaod e sem erros
			Console.WriteLine("Livro cadastrado com sucesso!");
			//ReadKey apenas para que ele visualize esta informação.
			Console.ReadKey();
		}

		private static void AdicionarUsuario()
		{
			//identificamos uqe o mesmo esta na parte de cadastro de livros do sistema
			Console.WriteLine("Cadastrar novo usuario no sistema:");
			//informamos que para dar continuidade ele deve informar um nome para o livro
			Console.WriteLine("Login do usuario para cadastro");
			//obtemos esta informação do usuario
			var loginDoUsuario = Console.ReadLine();
			//"livroController" livros controle e nosso "objeto" em memoria
			//com isso temos disponivel nele ferramentas que nos ajudam a realizar as tarefas
			//como adicionar um item a nossa lista de livros
			Console.WriteLine("Senha do usuario para cadastro");
			var senhaDoUsuario = Console.ReadLine();

			Usuario.AdicionarUsuario (new Usuario()
			{
				//Aqui "Atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
				//com o sinal de panes "=" temos atribuição, passagem de valor
				Login = loginDoUsuario,
				Senha = senhaDoUsuario

			});
			
			//indico que finalizamos o processo de cadastro do livro, assim o usuario já sabe
			//que o mesmo foi realizaod e sem erros
			Console.WriteLine("usuario cadastrado com sucesso!");
			//ReadKey apenas para que ele visualize esta informação.
			Console.ReadKey();
		}
		private static bool RealizaLoginSistema()
        {
            Console.WriteLine(@"


            Bem vindo a Biblioteca da HBSIS");
            Console.ReadKey();
            Console.WriteLine(@"


            Informe seu Login e senha para acessar");
            Console.ReadKey();

            Console.WriteLine("Login: ");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha: ");
            var senhaDoUsuario = Console.ReadLine();

           
            return Usuario.LoginSistema  (new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });

        }
        private static void MostrarLivros()
        {
            livrosController.RetornaListaDeLivros().ForEach(item => Console.WriteLine($"ID do livro {item.Id} Nome do livro:{item.Nome}"));
            //Para cada livro cadastrado temos a demostração no console por esta parte
            // Console.WriteLine($"Nome do livro:{i.Nome}"));
            Console.ReadKey();
        }
		private static void ListarLivros()
		{
			livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"Id{i.Id} e nome:  {i.Nome}"));
			Console.ReadKey();
			MostraMenuSistema();
			/*{
			 Nome = " 'O Homem Mais Inteligente da História -  Augusto Cury - 9788543104355' "
		 };

		 Console.WriteLine($"Meu livro é: {livro.Nome}");*/

			/* var conteudo = @"livro:Textos Cruéis Demais Para Serem Lidos Rapidamente,autor:Vários Autores,ano:2018;livro:1984,autor:George Orwell,ano:1949;" +
				 "livro:Fahrenheit 451,autor:Ray Bradbury,ano:2012;livro:Admirável Mundo Novo,autor:Aldous Huxley,ano:2008;" +
				 "livro:A Revolução dos Bichos,autor:George Orwell,ano:2007";

			 var listaDeInformacoes = conteudo.Split(';');
			 Console.WriteLine(@"



			 Livros disponiveis no nosso sistema:");


			 foreach (var item in listaDeInformacoes)
			 {
				 Console.WriteLine(item.Split(',')[0]);
			 }
			 Console.WriteLine("informe um livro ao sistema");
			 var nomeBusca = Console.ReadLine();


			 foreach (var item in listaDeInformacoes)
			 {
				 var inforacoesSplit = item.Split(',');

				 var nome = inforacoesSplit[0].Split(':')[1];
				 var idade = inforacoesSplit[1].Split(':')[1];
				 var ano = inforacoesSplit[2].Split(':')[1];



				 if (nome == nomeBusca)
				 {
					 Console.WriteLine($"livro: {nome} do autor {idade} do ano {ano} foi alocado");
				 }
			 }*/
		}
		
        /// <summary>
        /// metdoo que mostra livros ja cadastrados em nossa lista
        /// </summary>

        private static void MostrarUsuarios()
        {
            Usuario.RetornaListaDeUsuarios().ForEach (i => Console.WriteLine($"Id é:{i.Id}, com o Login: {i.Login}."));
            //usuario.Usuario.ForEach

            Console.ReadKey();
        }

    }

}

