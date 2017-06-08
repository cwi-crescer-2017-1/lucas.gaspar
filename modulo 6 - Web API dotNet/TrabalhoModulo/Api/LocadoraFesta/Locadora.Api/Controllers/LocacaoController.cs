using Locadora.Api.App_Start;
using Locadora.Dominio;
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
    [RoutePrefix("api/locacao")]
    public class LocacaoController : ApiController
    {
        private readonly LocacaoRepositorio repositorio = new LocacaoRepositorio();
        [HttpPost]
        public IHttpActionResult IncluirLocacao(Locacao locacao)
        {
            var locacaoFeita = new Locacao(locacao.Produto, locacao.Pacote, locacao.Cliente, locacao.DataLocacao, locacao.DataEntregaPrevista, locacao.Item);
            repositorio.IncluirLocacao(locacaoFeita);

            return Ok(new { dados = locacaoFeita });
        }
    }
}
