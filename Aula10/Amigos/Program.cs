using Amigos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeAmigos = new List<AmigosHBSIS>();

            listaDeAmigos.Add(new AmigosHBSIS(){
                Nome = "Lucas",
                Tempo = 2
            });
            listaDeAmigos.Add(new AmigosHBSIS()
            {
                Nome = "Mateus",
                Tempo = 3
            });
            listaDeAmigos.Add(new AmigosHBSIS()
            {
                Nome = "Maria",
                Tempo = 1
            });

            listaDeAmigos.ForEach(Amigos => Console.WriteLine($"Eu o {Amigos.Nome} somos amigos ha {Amigos.Tempo} anos"));
            Console.ReadKey();
        }
        
    }
}
