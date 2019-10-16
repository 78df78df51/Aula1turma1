
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C.Model
{
    class Listas
    {
        static void Main(string[] args)
        {

            var objetoPessoa = new Pessoa();

            Console.WriteLine("Informe seu nome: ");
            objetoPessoa.Nome = Console.ReadLine();

            Console.WriteLine("informe sua idade: ");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("sexo M ou F");
            objetoPessoa.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("informe sua altura: ");
            objetoPessoa.Altura = double.Parse(Console.ReadLine());

            cadastro2.Add(objetoPessoa);

            Console.Clear();
            cadastro2.ForEach(ob => Console.WriteLine($"Me chamo {objetoPessoa.Nome} possuo {ob.Idade}, sou do sexo {ob.Sexo} e tenho {ob.Altura}."));
            Console.ReadKey();















            //List<int> numeros = new List<int>();
            //Random rdm = new Random();


            //for (int i = 0; i < 10; i++)
            //{
            //    //gera um numero aleatorio de 0 a 100
            //    int valorGeradoAleatoriamente = rdm.Next(100);
            //    //verirfica se a lista não contem numeto gerado
            //    bool ehRepetido = numeros.Contains(valorGeradoAleatoriamente);
            //        if (!numeros.Contains(valorGeradoAleatoriamente))
            //        {
            //        //Adiciona o numero gerado pelo random (que ñ é repetido)
            //        numeros.Add(valorGeradoAleatoriamente);
            //        }
            //        else
            //    {
            //        i--;
            //    }

        }
            Console.ReadLine();
        }

    internal class Pessoa
    {
        public string Nome { get; internal set; }
    }
}
}
