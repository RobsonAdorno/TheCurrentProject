using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasEcoville.Model;

namespace VendasEcoville.DAL
{
    class VendedorDAO
    {
        private static List<Vendedor> vendedores = new List<Vendedor>();

        public static bool CadastrarVendedor(Vendedor vendedor)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if (vendedorCadastrado.Cpf.Equals(vendedor.Cpf))
                {
                    return false;
                }
            }
            vendedores.Add(vendedor);
            return true;
        }

        public static List<Vendedor> RetornarVendedores()
        {
            return vendedores;
        }
    }
}
