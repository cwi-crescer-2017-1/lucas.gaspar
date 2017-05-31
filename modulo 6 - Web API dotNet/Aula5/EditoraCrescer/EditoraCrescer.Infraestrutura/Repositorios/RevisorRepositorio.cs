using EditoraCrescer.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescer.Infraestrutura.Repositorios
{
    public class RevisorRepositorio
    {
        private Contexto contexto = new Contexto();

        public List<Revisor> Obter()
        {
            return contexto.Revisores.toList();
        }

        public void Incluir(Revisor revisor)
        {
            contexto.Revisores.Add(revisor);
            contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            Revisor revisorASerDeletado = contexto.Revisores.FirstOrDefault(r => r.Id == id);
            contexto.Revisores.Remove(revisorASerDeletado);
            contexto.SaveChanges();
        }
    }
}
