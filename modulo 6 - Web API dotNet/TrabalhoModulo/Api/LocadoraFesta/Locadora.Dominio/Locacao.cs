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
        public DateTime? DataEntregaReal { get; set; }
        public double PrecoTotal { get; set; }
        public List<Item> Item { get; set; }

        protected Locacao() { }

        public Locacao(Produto produto, Pacote pacote, Cliente cliente, DateTime dataLocacao, DateTime dataEntregaPrevista, List<Item> item)
        {
            Produto = produto;
            Pacote = pacote;
            Cliente = cliente;
            DataLocacao = dataLocacao;
            DataEntregaPrevista = dataEntregaPrevista;
            Item = item;
        }
        public double calcularPreco(double preco, double itens)
        {
            return preco+itens;
        }
    }
}
