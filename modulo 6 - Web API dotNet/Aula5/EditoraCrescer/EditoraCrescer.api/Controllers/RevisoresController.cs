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
    public class RevisoresController : ApiController
    {
        private RevisorRepositorio repositorio = new RevisorRepositorio();

        public IHttpActionResult Get()
        {
            var revisores = repositorio.Obter();

            return Ok();
        }

        public IHttpActionResult Post(Revisor revisor)
        {
            repositorio.Incluir(revisor);

            return Ok();
        }

        public IHttpActionResult delete(int id)
        {
            repositorio.Deletar(id);

            return Ok();
        }
    }
}

