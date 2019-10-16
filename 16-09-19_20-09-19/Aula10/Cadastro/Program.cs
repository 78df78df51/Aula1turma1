using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cadastro
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var cadastro2 = new List<Pessoa>();

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
        }   
    
    }
    
}
