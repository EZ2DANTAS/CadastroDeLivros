using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeLivros.Entidades
{
    /*
           Cadastro de Usuários:

           Crie uma classe Usuario com atributos como nome, idade, e ID.
           Implemente uma classe Bibliotecario que gerencie os usuários da biblioteca.
           Permita a adição, remoção, edição e exibição de informações dos usuários.

   */
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
