using Locadora.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora.Api.Models
{
    public class ClienteModel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cpf { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}