using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Julia
{
    class Program
    {
        static void Main(string[] args)
        {

            String opcao;
            String id;
            Boolean continuar = true;
            List<Biblioteca> listaLivros = new List<Biblioteca>();
            List<Biblioteca> listaPesquisa = new List<Biblioteca>();

            do
            {
                Console.WriteLine("Cadastro - Biblioteca" + Environment.NewLine);
                Console.WriteLine("Menu" + Environment.NewLine);
                Console.WriteLine("01 - Incluir");
                Console.WriteLine("02 - Alterar");
                Console.WriteLine("03 - Excluir");
                Console.WriteLine("04 - Listar");
                Console.WriteLine("05 - Pesquisar");
                Console.WriteLine("06 - Sair" + Environment.NewLine);
                Console.WriteLine("Digite a opção desejada:");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "01":
                        listaLivros.Add(inserirLivro("0"));
                        break;
                    case "02":
                        Console.WriteLine("\nAlterar");

                        Console.WriteLine("Indique o Id:");

                        id = Console.ReadLine();

                        listaLivros.RemoveAll(x => x.Id == id);

                        listaLivros.Add(inserirLivro(id));

                        break;
                    case "03":
                        Console.WriteLine("Excluir" + Environment.NewLine);

                        Console.WriteLine("Indique o Id:");

                        id = Console.ReadLine();

                        listaLivros.RemoveAll(x => x.Id == id);

                        Console.WriteLine("\nLivro excluído com sucesso!" + Environment.NewLine);

                        break;
                    case "04":
                        Console.WriteLine("\nListagem" + Environment.NewLine);

                        foreach (Biblioteca livrinhos in listaLivros)
                        {
                            Console.WriteLine("Id: " + livrinhos.Id);
                            Console.WriteLine("Nome: " + livrinhos.Nome);
                            Console.WriteLine("Autor: " + livrinhos.Autor);
                            Console.WriteLine("Editora: " + livrinhos.Editora + Environment.NewLine);
                        }

                        break;
                    case "05":
                        Console.WriteLine("Pesquisar");
                        Console.Write("Indique o Id: ");

                        id = Console.ReadLine();
                        listaLivros.Find(x => x.Id == id);

                        break;

                    case "06":
                        Console.WriteLine("Seu aplicativo foi encerrado!");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção não existente!");
                        break;
                }
            } while (continuar);
        }

        private static Biblioteca inserirLivro(string id)
        {
            Biblioteca livro = new Biblioteca();

            if (id != "0")
            {
                Console.WriteLine("\nEdição de Livro");
                livro.Id = id;
                Console.Write("Insira o nome: ");
                livro.Nome = Console.ReadLine();
                Console.Write("Insira o autor: ");
                livro.Autor = Console.ReadLine();
                Console.Write("Insira a editora: ");
                livro.Editora = Console.ReadLine() + Environment.NewLine;

                Console.WriteLine("Edição efetuada com sucesso!");
            }
            else
            {
                Console.WriteLine("\nCadastro de Livro");
                Console.Write("Insira o id: ");
                livro.Id = Console.ReadLine();
                Console.Write("Insira o nome: ");
                livro.Nome = Console.ReadLine();
                Console.Write("Insira o autor: ");
                livro.Autor = Console.ReadLine();
                Console.Write("Insira a editora: ");
                livro.Editora = Console.ReadLine() + Environment.NewLine;

                Console.WriteLine("Cadastro efetuado com sucesso!");
            }
            return livro;
        }



    }
}
