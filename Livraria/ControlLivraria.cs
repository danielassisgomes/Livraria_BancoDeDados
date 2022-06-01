using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlLivraria
    {
        Compra compra;
        Cliente cliente;
        Livros livros;


        private int opcao;
        public ControlLivraria()
        {
            compra = new Compra();
            cliente = new Cliente();
            livros = new Livros();

        }// fim método ControlLivraria

        public int AcessarOpcao
        {

            get
            {
                return opcao;
            }

            set
            {
                this.opcao = value;
            }

        }// fim método AcessarOpcao

        public void Menu()
        {

            Console.WriteLine("\n\nEscolha uma das opções abaixo\n\n" +
                                    "1.Cadastrar\n" +
                                    "2.Consultar Tudo\n" +
                                    "3.Livros\n" +
                                    "4.Categorias\n" +
                                    "5.Autores\n" +
                                    "6.Cadastro da Compra\n" +
                                    "7.Consulta de compra");
                                 

            AcessarOpcao = Convert.ToInt32(Console.ReadLine());

        }// fim método Menu

        public void Executar()
        {
            do
            {
                Menu();
                switch (AcessarOpcao)
                {

                    case 1:

                        Console.WriteLine("Imforme um código");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe seu nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe sua Data de Nascimento:");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Informe seu telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Infome um Usuário: ");
                        string usuario = Console.ReadLine();
                        Console.WriteLine("Infome uma senha: ");
                        string senha = Console.ReadLine();
                        //Utilizando esses dados no método inserir
                        cliente.Inserir(nome, data, telefone, usuario, senha);
                        Console.WriteLine("Cadastrado com sucesso!");
                        break;

                    case 2:

                        Console.WriteLine("Informe seu usuário: ");
                        usuario = Console.ReadLine();
                        Console.WriteLine("Informe sua senha: ");
                        senha = Console.ReadLine();
                        Console.WriteLine(cliente.Login(usuario, senha));
                        break;

                    case 3:

                        Console.WriteLine("Informe seu código");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cliente.Consultar(codigo));
                        break;

                    case 4:

                        Console.WriteLine("Livros disponíveis:\n");
                        Console.WriteLine(livros.ConsultarLivros());

                        break;

                    case 5:

                        Console.WriteLine("\nEscolha uma categoria:\n1.Saúde\n2.Mangá\n3.Biografias e casos verdadeiros\n");
                        int codigocategoria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(livros.Categorias(codigocategoria));

                        break;

                    case 6:

                        Console.WriteLine("\nAutores disponíveis:\n1.Ana Suy\n2.Inio Asano\n3.Carlos Martinho");
                        Console.WriteLine("Digite o número do autor para ver seus livros disponíveis, ou digite 0 para voltar\n");

                        int codigoautor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(livros.Autor(codigoautor));

                        break;

                    case 7:

                        Console.WriteLine("Informe o Código de sua compra: ");
                        int codigoCompra = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a data de sua compra: ");
                        var dataCompra = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de livros que irá comprar");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a forma de pagamento: ");
                        string tipoPagamento = Console.ReadLine();

                        Console.WriteLine("Informe o valor total da compra: ");
                        decimal valorTotal = Convert.ToInt32(Console.ReadLine());

                        compra.CadastrarCompra(codigoCompra, dataCompra, quantidade, tipoPagamento, valorTotal);

                        Console.WriteLine("Cadastrado com sucesso!");

                        break;

                    case 8:

                        Console.WriteLine("Informe seu código");
                        codigoCompra = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(compra.ConsultarCompra(codigoCompra));

                        break;
                    default:
                        Console.WriteLine("Código informado não é válido.");
                        break;
                }// fim do switch

            } while (AcessarOpcao != 0);
        }// fim do método Executa
    }// fim class
}// fim projeto