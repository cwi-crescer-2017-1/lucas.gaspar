using EditoraCrescer.Infraestrutura.Entidades;
using EditoraCrescer.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EditoraCrescer.api.Controllers
{
    [RoutePrefix("api/Revisores")]
    public class RevisoresController : ApiController
    {
        private RevisorRepositorio repositorio = new RevisorRepositorio();

        [HttpGet]
        public IHttpActionResult ObterTodos()
        {
            var revisores = repositorio.Obter();

            return Ok(revisores);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult ObterPorId(int id)
        {
            var revisores = repositorio.ObterPorId(id);

            return Ok(revisores);
        }

        [HttpPost]
        public IHttpActionResult Post(Revisor revisor)
        {
            repositorio.Incluir(revisor);

            return Ok();
        }

        [Route("{id:int}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, Revisor revisor)
        {
            if (id != revisor.Id)
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    new { mensagens = new string[] { "Ids não conferem" } });

            if (!repositorio.VerificaSeORevisorExiste(id))
                return Request.CreateResponse(HttpStatusCode.NotFound,
                    new { mensagens = new string[] { "Revisor não encontrado" } });

            repositorio.Alterar(revisor);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("{id:int}")]
        [HttpDelete]
        public HttpResponseMessage delete(int id)
        {
            var revisor = repositorio.ObterPorId(id);
            if (revisor == null)
                return Request.CreateResponse(HttpStatusCode.NotFound,
                    new { mensagens = new string[] { "Autor não encontrado" } });

            repositorio.Deletar(revisor);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            repositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}

