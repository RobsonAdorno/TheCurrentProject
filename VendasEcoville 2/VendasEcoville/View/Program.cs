using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasEcoville.DAL;
using VendasEcoville.Model;
using VendasEcoville.Utils;

namespace VendasEcoville.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c;
            Vendedor v;
            Produto p;

            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Vendedores");
                Console.WriteLine("4 - Listar Vendedores");
                Console.WriteLine("5 - Cadastrar Produtos");
                Console.WriteLine("6 - Listar Produtos");
                Console.WriteLine("7 - Realizar Venda");
                Console.WriteLine("8 - Listar Venda");
                Console.WriteLine("9 - Listar Venda por Cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a sua opção:");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        c = new Cliente();
                        Console.Clear();
                        Console.WriteLine("  -- CADASTRAR CLIENTE --  \n");
                        Console.WriteLine("Digite o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();
                        if (Validar.Cpf(c.Cpf))
                        {
                            if (ClienteDAO.CadastrarCliente(c))
                            {
                                Console.WriteLine("Cliente cadastrado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Cliente já existente!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("CPF inválido!");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("  -- LISTAR CLIENTES --  \n");
                        //for (int i = 0; i < clientes.Count; i++)
                        //{
                        //    Console.WriteLine("Nome: " + clientes[i].Nome);
                        //    Console.WriteLine("CPF: " + clientes[i].Cpf + "\n");
                        //}
                        foreach (Cliente clienteCadastrado in ClienteDAO.RetornarClientes())
                        {
                            Console.WriteLine("Nome: " + clienteCadastrado.Nome);
                            Console.WriteLine("CPF: " + clienteCadastrado.Cpf + "\n");
                        }
                        break;
                    case 3:
                        v = new Vendedor();
                        Console.Clear();
                        Console.WriteLine("  -- CADASTRAR VENDEDOR -- \n");
                        Console.WriteLine("Digite o nome do vendedor:");
                        v.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do vendedor:");
                        v.Cpf = Console.ReadLine();
                        if (Validar.Cpf(c.Cpf))
                        {
                            if (VendedorDAO.CadastrarVendedor(v))
                            {
                                Console.WriteLine("Vendedor cadastrado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Vendedor já existente!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("CPF inválido!");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("  -- LISTAR VENDEDORES -- \n");
                        foreach (Vendedor vendedorCadastrado in VendedorDAO.RetornarVendedores())
                        {
                            Console.WriteLine("Nome: " + vendedorCadastrado.Nome);
                            Console.WriteLine("CPF: " + vendedorCadastrado.Cpf + "\n");
                        }
                        break;
                    case 5:
                        p = new Produto();
                        Console.Clear();
                        Console.WriteLine("  -- CADASTRAR PRODUTO -- \n");
                        Console.WriteLine("Digite o nome do produto:");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto:");
                        p.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade do produto:");
                        p.Quantidade = Convert.ToInt32(Console.ReadLine());
                        if (ProdutoDAO.CadastrarProduto(p))
                        {
                            Console.WriteLine("Produto cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto já existente!");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("  -- LISTAR PRODUTOS -- \n");
                        foreach (Produto produtoCadastrado in ProdutoDAO.RetornarProdutos())
                        {
                            Console.WriteLine("Nome: " + produtoCadastrado.Nome);
                            Console.WriteLine("Preço: " + produtoCadastrado.Preco.ToString("C2"));
                            Console.WriteLine("Quantidade: " + produtoCadastrado.Quantidade + "\n");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (op != 0);

        }
    }
}
