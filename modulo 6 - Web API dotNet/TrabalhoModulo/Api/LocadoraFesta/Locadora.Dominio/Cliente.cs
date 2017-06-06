using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cpf { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }

        protected Cliente() { }

        public Cliente(string nome, string endereco, string cidade, string cpf, Genero genero, DateTime dataNascimento)
        {
         
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
            Cpf = cpf;
            Genero = Genero;
            DataNascimento = dataNascimento;
        }

    }
}
