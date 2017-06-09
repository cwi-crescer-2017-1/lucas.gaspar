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
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        private readonly ProdutoRepositorio repositorio = new ProdutoRepositorio();

        [HttpGet]
        public IHttpActionResult ObterProdutos()
        {
            var produtos = repositorio.ObterProdutos();
            return Ok(new { dados = produtos });
        }
    }
}
