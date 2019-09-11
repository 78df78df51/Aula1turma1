using System;

namespace StringTypesConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = @"alguma coisa +  alguma infor here AMBEV";

            var teste1 = Console.ReadLine();
            var teste2 = Console.ReadLine();
            var teste3 = teste1 +"\r\n"+ teste2;

            Console.WriteLine(teste3);

            var testeTemplate = @"Nome do usuario:{0} Idade:{1} Descrição:{2}";
            var finishText = string.Format(testeTemplate
                , Console.ReadLine()
                , Console.ReadLine()
                , Console.ReadLine());

            Console.WriteLine(teste);
            Console.ReadLine();
        }
    }
}
