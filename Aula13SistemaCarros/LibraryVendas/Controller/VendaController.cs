using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVendas.Controller
{
    public class VendaController
    {
        VendaContext vendaContext = new VendaContext();
        //aqui cria os métodos
        public void emitir()
        {
            vendaContext.ListaDeInformacoes.ForEach(x => Console.WriteLine(x.Carro));
        }

    }
}
