using Locadora.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class EmpregadoRepositorio
    {
        public EmpregadoRepositorio()
        {

        }
        private Contexto contexto = new Contexto();
        public Empregado Obter(string email)
        {
            return contexto.Empregado.FirstOrDefault(e => e.Email == email);
        }

    }
}
