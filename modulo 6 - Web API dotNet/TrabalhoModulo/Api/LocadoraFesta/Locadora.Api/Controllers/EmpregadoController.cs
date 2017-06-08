using Locadora.Api.App_Start;
using Locadora.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Locadora.Api.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/acessos")]
    public class EmpregadoController : ControllerBasica
    {

        readonly EmpregadoRepositorio _empregadoRepositorio;

        public EmpregadoController()
        {
            _empregadoRepositorio = new EmpregadoRepositorio();
        }

        [BasicAuthorization]
        [HttpGet, Route("usuario")]
        public HttpResponseMessage Obter()
        {
            var empregado = _empregadoRepositorio.Obter(Thread.CurrentPrincipal.Identity.Name);

            if (empregado == null)
                return ResponderErro("Usuário não encontrado.");

            return ResponderOK(new { empregado.Nome, empregado.Permissao, empregado.Email });
        }
    }
}
