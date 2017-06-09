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
        public double calcularPreco(double preco, double itens, DateTime dataLocacao, DateTime dataEntregaPrevista)
        {
            var diaria = preco+itens;
            var diferencaDeDias = (dataEntregaPrevista - dataLocacao).TotalDays;
            return diaria * diferencaDeDias;
        }

        public void AtribuirDataDevolucao()
        {
            DateTime hoje = DateTime.Now;
            this.DataEntregaReal = hoje;
        }

        /*public double calcularAtraso()
        {
            DateTime hoje = DateTime.Now.Date;
            if (this.DataEntregaPrevista <= hoje)
            {
                var diferencaDeDias = (hoje - this.DataEntregaPrevista).TotalDays;
                double precoItens = 0;
                foreach (var i in this.Item)
                {
                    precoItens += i.Preco;
                }
                var diaria = this.Pacote.Preco + precoItens;
                return (diaria * diferencaDeDias) + this.PrecoTotal;
            }
            else
            {
                return this.PrecoTotal;
            }
        }*/
    }
}
