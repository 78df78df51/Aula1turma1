using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C.Model;

namespace C
{
   public class Program
    {
        static List<Carro> listaCarro = new List<Carro>();
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para inserir. ");
            var opcao = Console.ReadLine();
            var cadastro2 = new List<Carro>();

            while (opcao == "1")
            {
                AdicionarLista();
                Console.WriteLine("Digite 1 para inserir.");
                opcao = Console.ReadLine();
            }
            listar();
            Console.ReadKey();

        }
        public static void AdicionarLista()
        {
            var ObjetoCarro = new Carro();

            Console.WriteLine("Informe a marca do seu carro ");
            ObjetoCarro.Marca = Console.ReadLine();

            Console.WriteLine("modelo: ");
            ObjetoCarro.Modelo = Console.ReadLine();

            Console.WriteLine("ano: ");
            ObjetoCarro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("valor: ");
            ObjetoCarro.Valor = int.Parse(Console.ReadLine());

            listaCarro.Add(ObjetoCarro);

            Console.Clear();

           
        }
        public static void listar()
        {
            listaCarro.ForEach(ob => Console.WriteLine($"Carro da marca: {ob.Marca} do modelo: {ob.Modelo} " +
               $", ano: {ob.Ano} e valor de: {ob.Valor}."));           
        }
    }
}
