using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Entidades
{
    public class locacao
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set;}
        public int IdPacote { get; set; }
        public Pacote Pacote { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataEntregaPrevista { get; set; }
        public DateTime DataEntregaReal { get; set; }
        public List<Item> Item { get; set; }



    }
}
