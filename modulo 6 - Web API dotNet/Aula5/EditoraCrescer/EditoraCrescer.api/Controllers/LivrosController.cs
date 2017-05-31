﻿using EditoraCrescer.Infraestrutura;
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

        public IHttpActionResult Get()
        {
            var livros = repositorio.Obter();

            return Ok();
        }

        public IHttpActionResult Post(Livro livro)
        {
            repositorio.Incluir(livro);

            return Ok();
        }

        public IHttpActionResult delete(int id)
        {
            repositorio.Deletar(id);

            return Ok();
        }
    }
}
