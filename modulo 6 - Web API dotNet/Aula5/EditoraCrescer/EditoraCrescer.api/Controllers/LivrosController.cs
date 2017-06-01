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
    public class LivrosController : ApiController
    {
        private LivroRepositorio repositorio = new LivroRepositorio();

        [Route("api/Livros")]
        [HttpGet]
        public IHttpActionResult Obter()
        {
            var livros = repositorio.Obter();

            return Ok(livros);
        }

        [Route("api/Livros/{isbn:int}")]
        [HttpGet]
        public IHttpActionResult ObterPorId(int isbn)
        {
            var livro = repositorio.ObterPorId(isbn);

            return Ok(livro);
        }

        [Route("api/Livros/Lancamentos")]
        [HttpGet]
        public IHttpActionResult ObterLancamentos()
        {
            var livros = repositorio.ObterLancamentos();

            return Ok(livros);
        }

        [Route("api/Livros/{genero}")] 
        [HttpGet]
        public IHttpActionResult ObterPorGenero(string genero)
        {
            var livros = repositorio.ObterPorGenero(genero);

            return Ok(livros);
        }

        [Route("api/Livros")]
        [HttpPost]
        public IHttpActionResult Post(Livro livro)
        {
            repositorio.Incluir(livro);

            return Ok();
        }

        [Route("api/Livros/{isbn}")]
        [HttpPut]
        public HttpResponseMessage Put(int isbn, Livro livro)
        {

            if (isbn != livro.Isbn)
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    new { mensagens = new string[] { "Ids não conferem" } });

            repositorio.Alterar(livro);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/livros/{id}")]
        [HttpDelete]
        public IHttpActionResult delete(int id)
        {
            repositorio.Deletar(id);

            return Ok();
        }

    }
}
