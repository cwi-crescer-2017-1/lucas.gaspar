using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio
{
    public class Pacote
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }

        protected Pacote() { }

        public Pacote(string descricao, double preco, string nome)
        {

            Descricao = descricao;
            Preco = preco;
            Nome = nome;
        }
    }
}
