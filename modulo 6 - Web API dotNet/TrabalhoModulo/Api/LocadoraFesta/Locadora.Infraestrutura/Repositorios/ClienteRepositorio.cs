using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locadora.Dominio;

namespace Locadora.Infraestrutura.Repositorios
{
    public class ClienteRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        //Metodos

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void IncluirCliente(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            contexto.SaveChanges();
        }

        public List<Cliente> ObterClientes()
        {
            return contexto.Cliente.ToList();
        }
    }
}
