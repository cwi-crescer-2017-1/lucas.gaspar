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
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Cidade { get; private set; }
        public string Cpf { get; private set; }
        public Genero Genero { get; private set; }
        public DateTime DataNascimento { get; private set; }

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
