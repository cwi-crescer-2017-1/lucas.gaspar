using Locadora.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class PacoteRepositorio
    {
        private Contexto contexto = new Contexto();

        public void Dispose()
        {
            contexto.Dispose();
        }

        public List<Pacote> ObterPacotes()
        {
            return contexto.Pacote.ToList();
        }
    }
}
