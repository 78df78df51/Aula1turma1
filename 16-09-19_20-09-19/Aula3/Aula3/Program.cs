using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Program
    {
        //Iniciando uma constante de um número inteiro
        const int testeConst = 999;
        static void Main(string[] args)
        {
            var teste1 = "String";  // texto
            var teste2 = 'C'; //char
            var teste3 = 9; //Int
            var teste4 = 9.2; //Double
            var teste5 = 0x0F; //Hex
            //Apresentando a const
            Console.WriteLine(testeConst);
            return;
        }
    }
}
