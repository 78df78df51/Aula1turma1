using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
       {
            ForeachComSplitLista();
        }
        /// <summary>
        /// metodo que mostra como podemos utilizar o foreach para andar
        /// sobre um array de caracteres, ou seja um texto ou palavra etc...
        /// </summary>
        private static void IniciandoForeach01()
        {
            
            var texto = Console.ReadLine();
     
            foreach (var item in texto)
            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe seu nome por favor: ");
           
            var conteudoDoTexto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção
                    e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";
            

            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoDoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoDoTextoSplit)
            {
                if(palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
        }
        private static void ForeachComSplitLista()
        {
            var conteudo = " nome:Felipe,idade: 27; nome: Giomar,idade: 17; nome: Edson,Idade: 19; nome: Ericledson,idade: 75; nome: Junior,idade: 45";

            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Pessoas cadastradas no sistema:");
            

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            //Console.WriteLine("informe um carro ao sistema");
            var nomeBusca = Console.ReadLine();
            

            foreach (var item in listaDeInformacoes)
            {
                var inforacoesSplit = item.Split(',');

                var nome = inforacoesSplit[0].Split(':')[1];
                var idade = inforacoesSplit[1].Split(':')[1];
               


                if (int.Parse(idade) >= 18)
                {
                    Console.WriteLine($"o {nome} possui {idade}, portanto é possui maior idade");
                }
                else
                {
                    Console.WriteLine($"o {nome} não possui maior idade");
                }


            }
            Console.ReadKey();
        }
    }
    
}
