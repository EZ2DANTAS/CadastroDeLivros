using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeLivros.Entidades
{
    internal class Biblioteca
    {
        public List<Livro> livros = new List<Livro>();


        public void Adicionar(int isbn, string nome, string autor)
        {
            livros.Add(new Livro(isbn, nome, autor));
        }

        public void Remover(string nome)
        {
            try
            {
                Livro result = livros.Find(x => x.Nome == nome);
                livros.Remove(result);
                if (result != null)
                {
                    Console.WriteLine("Livro Removido com Suscesso !!!");
                }
                else
                {
                    Console.WriteLine("Livro Não Removido");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Exibir()
        {
            foreach (Livro item in livros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
