using Locadora.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class ProdutoRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        //Metodos

        public void Dispose()
        {
            contexto.Dispose();
        }

        public List<Produto> ObterProdutos()
        {
            return contexto.Produto.ToList();
        }
    }
}
