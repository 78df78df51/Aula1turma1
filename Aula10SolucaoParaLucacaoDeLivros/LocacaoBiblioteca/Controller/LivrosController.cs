using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        public LivrosController()
        {
            Livros = new List<Livros>();

            Livros.Add(new Livros()
            {
                Nome = "Meu Primeiro livro"
            });
            Livros.Add(new Livros()
            {
                Nome = "Meu Segundo livro"
            });
        }
        public List<Livros> Livros { get; set; }
    }
}
