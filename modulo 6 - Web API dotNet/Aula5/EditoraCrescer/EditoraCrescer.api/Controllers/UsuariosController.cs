using EditoraCrescer.api.App_Start;
using EditoraCrescer.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EditoraCrescer.api.Controllers
{
    [RoutePrefix("api/acessos/usuario")]
    public class UsuariosController : ApiController
    {
        private UsuarioRepositorio repositorio = new UsuarioRepositorio();

        [HttpGet]
        public IHttpActionResult ObterTodos(string email)
        {
            var usuarios = repositorio.Obter(email);

            return Ok();
        }
    }
}
