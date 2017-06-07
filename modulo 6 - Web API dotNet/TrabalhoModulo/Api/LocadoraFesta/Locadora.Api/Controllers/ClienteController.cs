using Locadora.Api.App_Start;
using Locadora.Api.Models;
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
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        private readonly ClienteRepositorio repositorio = new ClienteRepositorio();
        [HttpPost]
        public IHttpActionResult IncluirCliente(ClienteModel model)
        {
            var cliente = new Cliente(model.Nome, model.Endereco, model.Cidade, model.Cpf, model.Genero, model.DataNascimento);
            repositorio.IncluirCliente(cliente);

            return Ok(new { dados = cliente });
        }

        [HttpGet]
        public IHttpActionResult ObterQuantidadeLivrosPublicadosExcetoLancamentos()
        {
            var clientes = repositorio.ObterClientes();
            return Ok(new { dados = clientes });
        }
    }
}
