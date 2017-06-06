using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio
{
    public class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Permissao{ get; set; }

        protected Empregado() { }

        public Empregado(string nome, string email, string senha, string permissao)
        {

            Nome = nome;
            Email = email;
            Senha = senha;
            Permissao = permissao;
        }
    }
}
