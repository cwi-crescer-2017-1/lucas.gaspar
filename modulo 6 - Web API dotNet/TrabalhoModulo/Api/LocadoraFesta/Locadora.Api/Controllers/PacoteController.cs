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
    [RoutePrefix("api/pacote")]
    public class PacoteController : ApiController
    {
        private readonly PacoteRepositorio repositorio = new PacoteRepositorio();

        [HttpGet]
        public IHttpActionResult ObterPacotes()
        {
            var pacotes = repositorio.ObterPacotes();
            return Ok(new { dados = pacotes });
        }
    }
}
