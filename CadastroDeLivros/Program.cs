using System;
using System.Runtime.InteropServices;
using System.Xml;
using CadastroDeLivros.Entidades;

namespace CadastroDeLivros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            Cadastro de Usuários:

            Crie uma classe Usuario com atributos como nome, idade, e ID.
            Implemente uma classe Bibliotecario que gerencie os usuários da biblioteca.
            Permita a adição, remoção, edição e exibição de informações dos usuários.
              
             */
            Biblioteca biblioteca = new Biblioteca();

            int opcao;
            char continuar;
            string nome;
            int isbn;
            string autor;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Remover Livro");
                Console.WriteLine("3 - Exibir Lista");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("ISBN");
                        isbn = int.Parse(Console.ReadLine());
                        Console.WriteLine("Autor");
                        autor = Console.ReadLine();

                        biblioteca.Adicionar(isbn, nome, autor);
                        break;

                    case 2:
                        Console.WriteLine("Qual o Nome do livro ?");
                        nome = Console.ReadLine();
                        biblioteca.Remover(nome);
                        break;

                    case 3:
                        biblioteca.Exibir();
                        break;


                    default:
                        Console.WriteLine("Digite um numero valido");
                        break;
                }
                Console.WriteLine("Continue? (S/N)");
                continuar = char.Parse(Console.ReadLine());
                continuar = char.ToUpper(continuar);
                while(continuar != 'S' && continuar != 'N')
                {

                    Console.WriteLine("DIGITE CORRETAMENTE !");
                    Console.WriteLine("Continue? (S/N)");
                    continuar = char.Parse(Console.ReadLine());
                    continuar = char.ToUpper(continuar);
                }
            } while (continuar == 'S');

        }
    }
}
