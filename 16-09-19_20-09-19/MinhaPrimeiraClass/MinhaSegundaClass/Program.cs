using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaSegundaClass.Model;

namespace MinhaSegundaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<Frutas>();
            
               minhaCestaDeFrutas.Add(new Frutas()
               {
                   nome = "Maça",
                   Quantidade = 5
                  
               });
            minhaCestaDeFrutas.Add(new Frutas()
            {
                nome = "Morango",
                Quantidade = 2

            });

            minhaCestaDeFrutas.ForEach(i => Console.WriteLine($"Nome {i.nome} > Quant {i.Quantidade} "));
            Console.ReadKey();
        }
    }
}
