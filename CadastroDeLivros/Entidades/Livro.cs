using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeLivros.Entidades
{
    internal class Livro
    {
        public int Isbn { get; private set; }
        public string Nome { get; private set; }
        public string Autor { get; private set; }

        public Livro()
        {

        }
        public Livro(int isbn, string nome, string autor)
        {
            Isbn = isbn;
            Nome = nome;
            Autor = autor;
        }


        public override string ToString()
        {
            return $"Nome: {Nome}, Autor: {Autor}, ISBM: {Isbn}";
        }
    }
}
