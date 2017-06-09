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
    [RoutePrefix("api/relatorio")]
    public class RelatorioController : ApiController
    {
        private readonly LocacaoRepositorio repositorio = new LocacaoRepositorio();

        [HttpGet]
        public IHttpActionResult ObterRelatorioAtraso()
        {
            var relatorio = repositorio.ObterRelatorioAtraso();
            return Ok(new { dados = relatorio });
        }

        [HttpGet, Route("mensal")]
        public IHttpActionResult ObterRelatorioMensal()
        {
            var relatorio = repositorio.ObterRelatorioMensal();
            return Ok(new { dados = relatorio });
        }
    }
}
