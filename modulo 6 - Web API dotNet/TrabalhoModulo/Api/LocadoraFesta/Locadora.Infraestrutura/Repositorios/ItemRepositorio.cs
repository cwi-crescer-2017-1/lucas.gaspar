using Locadora.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class ItemRepositorio
    {
        private Contexto contexto = new Contexto();

        public List<Item> ObterItens()
        {
            return contexto.Item.ToList();
        }
    }
}
