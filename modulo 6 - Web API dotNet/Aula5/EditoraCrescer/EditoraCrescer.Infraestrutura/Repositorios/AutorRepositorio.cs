using EditoraCrescer.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescer.Infraestrutura.Repositorios
{
    public class AutorRepositorio
    {
        private Contexto contexto = new Contexto();

        public List<Autor> Obter()
        {
            return contexto.Autores.ToList();
        }

        public void Incluir(Autor autor)
        {
            contexto.Autores.Add(autor);
            contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            Autor autorASerDeletado = contexto.Autores.FirstOrDefault(a => a.Id == id);
            contexto.Autores.Remove(autorASerDeletado);
            contexto.SaveChanges();
        }

    }
}
