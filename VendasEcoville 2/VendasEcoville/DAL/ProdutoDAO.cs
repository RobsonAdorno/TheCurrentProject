using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasEcoville.Model;

namespace VendasEcoville.DAL
{
    class ProdutoDAO
    {
        private static List<Produto> produtos = new List<Produto>();

        public static bool CadastrarProduto(Produto produto)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (produtoCadastrado.Nome.Equals(produto.Nome))
                {
                    return false;
                }
            }
            produtos.Add(produto);
            return true;
        }

        public static List<Produto> RetornarProdutos()
        {
            return produtos;
        }
    }
}
