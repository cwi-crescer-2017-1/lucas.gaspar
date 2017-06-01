using EditoraCrescer.Infraestrutura;
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
    [RoutePrefix("api/Livros")]
    public class LivrosController : ApiController
    {
        private LivroRepositorio repositorio = new LivroRepositorio();

        [HttpGet]
        public IHttpActionResult Obter()
        {
            var livros = repositorio.Obter();

            return Ok(livros);
        }

        [Route("{isbn:int}")]
        [HttpGet]
        public IHttpActionResult ObterPorId(int isbn)
        {
            var livro = repositorio.ObterPorId(isbn);

            return Ok(livro);
        }

        [Route("Lancamentos")]
        [HttpGet]
        public IHttpActionResult ObterLancamentos()
        {
            var livros = repositorio.ObterLancamentos();

            return Ok(livros);
        }

        [Route("{genero}")] 
        [HttpGet]
        public IHttpActionResult ObterPorGenero(string genero)
        {
            var livros = repositorio.ObterPorGenero(genero);

            return Ok(livros);
        }

        [HttpPost]
        public IHttpActionResult Post(Livro livro)
        {
            repositorio.Incluir(livro);

            return Ok();
        }

        [Route("{isbn}")]
        [HttpPut]
        public HttpResponseMessage Put(int isbn, Livro livro)
        {
            if (isbn != livro.Isbn)
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    new { mensagens = new string[] { "Ids não conferem" } });

            if (!repositorio.VerificaSeOLivroExiste(isbn))
                return Request.CreateResponse(HttpStatusCode.NotFound,
                    new { mensagens = new string[] { "Livro não encontrado" } });

            repositorio.Alterar(livro);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("{id}")]
        [HttpDelete]
        public HttpResponseMessage delete(int id)
        {
            var livro = repositorio.ObterPorId(id);
            if (livro == null)
                return Request.CreateResponse(HttpStatusCode.NotFound,
                    new { mensagens = new string[] { "Livro não encontrado" } });

            repositorio.Deletar(livro);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            repositorio.Dispose();
            base.Dispose(disposing);
        }

    }
}
