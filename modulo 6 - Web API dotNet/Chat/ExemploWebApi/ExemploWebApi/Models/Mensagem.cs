using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebApi.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
    }
}