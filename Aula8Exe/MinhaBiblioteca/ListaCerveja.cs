using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListaCerveja
    {
        public static void Lista()
        {
            var listCerveja = new List<string>();

            listCerveja.Add("BRAHMA");
            listCerveja.Add("SKOL");
            listCerveja.Add("PATAGONIA");
            listCerveja.Add("ORIGINAL");
            listCerveja.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
    }
}
