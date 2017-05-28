using ExemploWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class MensagensController : ApiController
    {
        private static List<Mensagem> mensagens = new List<Mensagem>();
        private static int contador = 1;
        private static object @lock = new object();

        public IEnumerable<Mensagem> Get(int? id = null)
        {
            if (id == null)
            {
                return mensagens.OrderBy(m => m.Data);
            }
            else
                return mensagens.Where(m => m.Id == id);
            
        }

        public IHttpActionResult Post(Mensagem mensagem)
        {
            if (mensagem == null)
            {
                return BadRequest();
            }
            else
            {
                lock (@lock)
                {
                    mensagens.Add(mensagem);
                    mensagem.Id = contador++;
                }

                return Ok(mensagem);
            }
        }
    }
}
