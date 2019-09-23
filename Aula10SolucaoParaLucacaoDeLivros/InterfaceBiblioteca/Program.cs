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
            Console.Clear();
            Console.WriteLine("Sistema de locação de livro 1.0");

            Console.WriteLine("Menu sistema");
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Livros");
            Console.WriteLine("3 - Cadastrar Livro");
            Console.WriteLine("4 - trocar usuário");
            Console.WriteLine("0 - Sair");

            //aqui vamos pegar numero digitado e executar proxima funcao
            var opcao = Console.ReadLine();
            Console.Clear();
            switch (opcao)
            {
                case "1":
                    MostarUsuarios();
                    break;
                case "2":
                    Livros();
                    break;
                case "3":
                    
                    break;
                case "4":
                    Console.ReadKey();
                    while (!RealizaLoginSistema())
                        Console.WriteLine("Login e senha inválidos");
                    Console.Clear();
                    break;
                case "0":
                    Console.Clear();
                    Console.WriteLine("Saindo... até a próxima ");
                    break;
            }

        }
        /// <summary>
        /// Metodo que realiza os procedimentos completo de login dentro do sistema
        /// como solicitaçao de login e senha
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informdas estiverem corretas</returns>
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

            UsuarioController usuarioController = new UsuarioController();


            return  usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });

        }
        private static void MostrarLivros()
        {
            livrosController.Livros.ForEach(item => Console.WriteLine($"Nome do livro:{item.Nome}"));
            //Para cada livro cadastrado temos a demostração no console por esta parte
            // Console.WriteLine($"Nome do livro:{i.Nome}"));
            Console.ReadKey();
        }
        private static void Livros()
        {
            /* livros livro = new livros()
             {
                 Nome = " 'O Homem Mais Inteligente da História -  Augusto Cury - 9788543104355' "
             };

             Console.WriteLine($"Meu livro é: {livro.Nome}");*/

            var conteudo = @"livro:Textos Cruéis Demais Para Serem Lidos Rapidamente,autor:Vários Autores,ano:2018;livro:1984,autor:George Orwell,ano:1949;" +
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
            }

        }
        /// <summary>
        /// metdoo que mostra livros ja cadastrados em nossa lista
        /// </summary>

        private static void MostarUsuarios()
        {
            Usuario.Usuarios.ForEach(i => Console.WriteLine($"usuario selecionado é:{i.Login}, com a senha {i.Senha}."));
            //usuario.Usuario.ForEach

            Console.ReadKey();
        }

    }

}

