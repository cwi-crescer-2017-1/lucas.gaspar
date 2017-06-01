using EditoraCrescer.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescer.Infraestrutura.Repositorios
{
    public class RevisorRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        public List<Revisor> Obter()
        {
            return contexto.Revisores.ToList();
        }

        public void Incluir(Revisor revisor)
        {
            contexto.Revisores.Add(revisor);
            contexto.SaveChanges();
        }

        public void Deletar(Revisor revisor)
        {
            contexto.Revisores.Remove(revisor);
            contexto.SaveChanges();
        }

        public Revisor ObterPorId(int id)
        {
            return contexto.Revisores.FirstOrDefault(r => r.Id == id);
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public bool VerificaSeORevisorExiste(int id)
        {
            return contexto.Revisores.Count(r => r.Id == id) > 0;
        }

        public void Alterar(Revisor revisor)
        {
            contexto.Entry(revisor).State = EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
