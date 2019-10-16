using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryVendas.Vendas;


namespace LibraryVendas.Controller
{ //controle de informações
	public class VendaContext
	{
		public List<Venda> ListaDeInformacoes { get;  }
		
		public VendaContext()
		{
            ListaDeInformacoes = new List<Venda>();


            ListaDeInformacoes.Add(new Venda(){ Id =  1,  Carro = "isus Associates         "  , Valor =  9.010,  Data = DateTime.Parse("26/10/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	2,  Carro = "ursus Et Ltd	         "  , Valor = 9.010, Data = DateTime.Parse("26/10/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	3,  Carro = "isus Company		     "  , Valor = 7.200, Data = DateTime.Parse("29/01/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	4,  Carro = "dio Etiam Ligula Company"	, Valor = 5.245, Data = DateTime.Parse("16/02/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	5,  Carro = "u Nibh Inc.	         "  , Valor = 7.922, Data = DateTime.Parse("27/06/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	6,  Carro = "ellus Limited	         "  , Valor = 7.294, Data = DateTime.Parse("26/01/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	7,  Carro = "mperdiet PC	         "  , Valor = 8.305, Data = DateTime.Parse("06/09/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	8,  Carro = "lit Inc.	             "  , Valor = 5.398, Data = DateTime.Parse("09/06/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	9,  Carro = "Quam A Limited	         "  , Valor = 5.398, Data = DateTime.Parse("09/09/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	10, Carro = "Adipiscing Institute	 "  , Valor = 8.133, Data = DateTime.Parse("24/10/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	11, Carro = "Posuere At Velit Ltd	 "  , Valor = 5.121, Data = DateTime.Parse("19/11/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	12, Carro = "Nunc In Industries	     "  , Valor = 8.902, Data = DateTime.Parse("21/07/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	13, Carro = "Integer Vitae Nibh      "  , Valor = 6.313, Data = DateTime.Parse("02/02/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	14, Carro = "Tellus Nunc LectusCompan"  , Valor = 9.650, Data = DateTime.Parse("20/07/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	15, Carro = "Suspendisse LLC	     "  , Valor = 5.319, Data = DateTime.Parse("24/12/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	16, Carro = "Mauris Vestibulum Corp  "  , Valor = 5.790, Data = DateTime.Parse("14/11/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	17, Carro = "Sed Nec Corp.	         "  , Valor = 8.421, Data = DateTime.Parse("05/05/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	18, Carro = "Enim Nisl Elementum Inc."	, Valor = 5.904, Data = DateTime.Parse("26/06/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	19, Carro = "Ac Mattis Semper Corp   "  , Valor = 5.110, Data = DateTime.Parse("14/01/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	20, Carro = "Donec Tempus Lorem LLC  "	, Valor = 8.576, Data = DateTime.Parse("29/03/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	21, Carro = "Tempor Augue Ac Ltd	 "  , Valor = 9.072, Data = DateTime.Parse("09/07/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	22, Carro = "Diam Duis Mi LLC	     "  , Valor = 8.472, Data = DateTime.Parse("23/09/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =	23, Carro = "Aliquam Corp.	         "  , Valor = 6.607, Data = DateTime.Parse("28/09/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =  24, Carro = "t Libero Proin Foundatio"  , Valor = 8.710, Data = DateTime.Parse("24/01/2019")});
            ListaDeInformacoes.Add(new Venda(){ Id =  25, Carro = "Montes Institute        "  , Valor = 6.176, Data = DateTime.Parse("19/06/2019")});
        }
    }
	
}
