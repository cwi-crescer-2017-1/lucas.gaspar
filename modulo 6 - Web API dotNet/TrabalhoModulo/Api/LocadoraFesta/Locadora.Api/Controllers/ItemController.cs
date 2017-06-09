using Locadora.Api.App_Start;
using Locadora.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Locadora.Api.Controllers
{
    [BasicAuthorization]
    [RoutePrefix("api/item")]
    public class ItemController : ApiController
    {
        private readonly ItemRepositorio repositorio = new ItemRepositorio();
        [HttpGet]
        public IHttpActionResult ObterItens()
        {
            var itens = repositorio.ObterItens();
            return Ok(new { dados = itens });
        }
    }
}
