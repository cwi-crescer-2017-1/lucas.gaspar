using Locadora.Dominio;
using Locadora.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio
{
    public class Locacao
    {
        public int Id { get; set; }
        public Produto Produto { get; set;}
        public Pacote Pacote { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataEntregaPrevista { get; set; }
        public DateTime DataEntregaReal { get; set; }
        public List<Item> Item { get; set; }

        protected Locacao() { }
    }
}
