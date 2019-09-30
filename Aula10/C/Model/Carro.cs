using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Model
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Valor { get; set; }

        internal static void ForEach(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
