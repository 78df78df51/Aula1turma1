using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8Exe
{
   public class Program
    {
        static void Main(string[] args)
        {

            ForeachComSplitLista();
            Console.ReadKey();
        }
        public static void arvore()
        {
            var arvore = @"..-...-..--..-...-..-...-...-..-...-..--..-...-..--..-...-..--..-...-..-...-...

-...-...-..-...-..--..-...-..--..-...-..--..-...-..-...-...-..-...-..--..-...-.

..-...-..--..-...-..-...-...-..-...--*=#@@@@@@@#=+-..-...-..--..-...-..-...-...

-...-...-..-...-..--..-...-..--.-=@##################*--...-..-...-..--..-...-.

..-...-..--..-...-..-...-.-+*==#########################--..--..-...-..-...-...

-...-...-..-...-...-.-*#@###############################@*.-..-...-......-...-.

...................:#####################################@+....................

.................-#########################################....................

................-##########################################-...................

..-...-......-..*###########################################@=..-...-..-...-...

-...-...-..-...-=#############################################@:..-..--..-...-.

..-...-..--..-..:@#############################################=-...-..-...-...

-...-...-..-...-.:@############################################-..-..--..-...-.

..-...-..--..-...-.*@########################################+..-...-..-...-...

-...-...-..-...-...-.:@####################################-..-...-..--..-...-.

..-..............-....*##################################@+............-.......

.......................+@###############################@:.....................

.........................+#############################+.......................

...........................-+#@###################@=:-.........................

-...-...-..-...-...-..-...-..-...=@@@@@@@@@@@@@@@-.-...-...-..-...-..--..-...-.

..-...-..--..-...-..-...-...-..-..@@@@@@@@@@@@@@*--..-...-..-...-...-..-...-...

-...-...-..-...-..--..-...-..--..-*@@@@@@@@@@@@@-..-...-...-..-...-..--..-...-.

..-...-..--..-...-..-...-...-..-..*@@@@@@@@@@@@#.--..-...-..--..-...-..-...-...

-...-...-..-...-..--..-...-..--..-#@@@@@@@@@@@@@-..-...-...-..-...-..--..-...-.

..-...-...-..-...-..-...-...-..-.+@@@@@@@@@@@@@@:....-...-..-...-...-..-...-...

................................*@@@@@@@@@@@@@@@@:.............................

..............................+@@@@@@@@@@@@@@@@@@@@:...........................

...........................:#@@@W@##===#@@@@@@@@==#@@@+........................

.........................................-+=@@@@+..............................

..-...-..--..-...-..-...-...-..-...-...-..-...-...-..-...-..-...-...-..-...-...

-...-...-..-...-...-..-...-..--..-...-..-...-...-..-...-...-..-...-..--..-...-.";
            Console.WriteLine(arvore);
        }
        public static void cerveja()
        {
            var listCerveja = new List<string>();

            listCerveja.Add("BRAHMA");
            listCerveja.Add("SKOL");
            listCerveja.Add("PATAGONIA");
            listCerveja.Add("ORIGINAL");
            listCerveja.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
        public static void ForeachComSplitLista()
        {
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;" +
                "carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015;carro:Porsche 356,marca:volkswagen,ano:1948";

            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Carros cadastrados no sistema:");


            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("informe um carro ao sistema");
            var nomeBusca = Console.ReadLine();


            foreach (var item in listaDeInformacoes)
            {
                var inforacoesSplit = item.Split(',');

                var nome = inforacoesSplit[0].Split(':')[1];
                var idade = inforacoesSplit[1].Split(':')[1];
                var ano = inforacoesSplit[2].Split(':')[1];
                


                if (nome == nomeBusca)
                {
                    Console.WriteLine($"o carro {nome} pertence a marca {idade} do ano {ano}");
                }


            }
            
        }
        public static void quadrado()
        {
            Console.WriteLine("informe um dos lados do quadrado");
            var ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o outro lado do quadrado");
            var ladoB = double.Parse(Console.ReadLine());

            double areaTotal = ladoA * ladoA;

            Console.WriteLine($"A área total do quadradado é: {areaTotal}");
           
        }
    }
}

