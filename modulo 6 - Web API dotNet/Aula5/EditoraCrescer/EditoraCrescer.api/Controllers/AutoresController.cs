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
    [RoutePrefix("api/Autores")]
    public class AutoresController : ApiController
    {
        private AutorRepositorio repositorio = new AutorRepositorio();

        [HttpGet]
        public IHttpActionResult ObterTodos()
        {
            var autores = repositorio.Obter();

            return Ok(autores);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult ObterPorId(int id)
        {
            var autores = repositorio.ObterPorId(id);

            return Ok(autores);
        }

        [HttpGet]
        [Route("{id:int}/Livros")]
        public IHttpActionResult ObterLivrosAutor(int id)
        {
            var livros = repositorio.ObterLivrosAutor(id);

            return Ok(livros);
        }

        [HttpPost]
        public IHttpActionResult Post(Autor autor)
        {
            repositorio.Incluir(autor);

            return Ok();
        }

        [Route("{id:int}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, Autor autor)
        {
            if (id != autor.Id)
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    new { mensagens = new string[] { "Ids não conferem" } });

            if (!repositorio.VerificaSeOAutorExiste(id))
                return Request.CreateResponse(HttpStatusCode.NotFound,
                    new { mensagens = new string[] { "Livro não encontrado" } });

            repositorio.Alterar(autor);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("{id:int}")]
        [HttpDelete]
        public HttpResponseMessage delete(int id)
        {
            var autor = repositorio.ObterPorId(id);
            if (autor == null)
                return Request.CreateResponse(HttpStatusCode.NotFound,
                    new { mensagens = new string[] { "Autor não encontrado" } });

            repositorio.Deletar(autor);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            repositorio.Dispose();
            base.Dispose(disposing);
        }

    }
}
