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

        [Route("api/Livros/{id:int}")]
        [HttpGet]
        public IHttpActionResult ObterPorId(int id)
        {
            var livro = repositorio.ObterPorId(id);

            return Ok(livro);
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

        [Route("api/livros/{id}")]
        [HttpDelete]
        public IHttpActionResult delete(int id)
        {
            repositorio.Deletar(id);

            return Ok();
        }

        [Route("api/livros/{id}")]
        [HttpPut]
        public IHttpActionResult put(int id, Livro livro)
        {
            repositorio.Alterar(id, livro);

            return Ok(livro);
        }
    }
}
