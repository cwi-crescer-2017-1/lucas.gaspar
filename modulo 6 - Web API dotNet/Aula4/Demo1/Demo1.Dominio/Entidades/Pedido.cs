using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public bool Validar(out List<string> mensagens)
        {
            mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(NomeCliente))
            {
                mensagens.Add("Nome do cliente não pode ser nulo");
            }

            bool isEmpty = !Itens.Any();

            if (isEmpty)
            {
                mensagens.Add("O pedido precisa ter itens vinculados");
            }

            /*for (int i = 0; i < Itens.Count; i++)
            {
                Itens[0].Quantidade > 
            }*/


            return true;
        }

    }
}
