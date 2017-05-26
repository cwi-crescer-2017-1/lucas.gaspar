using ExemploWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class HeroisController : ApiController
    {
        public static int idHeroi = 4;
        public static List<Heroi>herois = new List<Heroi>()
            {
                new Heroi() {Id=1, Nome= "Goku", poder = new Poder() { Nome="Genki Dama", Dano=5000 } },
                new Heroi() {Id=2, Nome= "Luffy", poder = new Poder() { Nome="Gear Third", Dano=9000 } },
                new Heroi() {Id=3, Nome= "Yatogami", poder = new Poder() { Nome="Senki", Dano=2000 } },
                new Heroi() {Id=4, Nome= "AL", poder = new Poder() { Nome="Alquimia", Dano=3000 } }
            };

        public IEnumerable<Heroi> Get(int? id=null)
        {

         
            if (id == null)
            {
                return herois;
            }
            else
            {
                return herois.Where(h => h.Id == id);
            }
        }

        public IHttpActionResult Post(Heroi heroi)
        {
            if (heroi != null) 
            {
                heroi.Id = ++idHeroi;
                Heroi h1 = new Heroi();

                h1.Id = heroi.Id;
                h1.Nome = heroi.Nome;
                h1.poder = heroi.poder;

                herois.Add(h1);

                return Ok(h1);
            }
            else
            {
                return BadRequest();
            }          
        }
    }
}
