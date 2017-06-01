using EditoraCrescer.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescer.Infraestrutura.Repositorios
{
    public class AutorRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        public List<Autor> Obter()
        {
            return contexto.Autores.ToList();
        }

        public Autor ObterPorId(int id)
        {
            return contexto.Autores.FirstOrDefault(a => a.Id == id);
        }

        public List<Livro> ObterLivrosAutor(int id)
        {
            var autor = contexto.Autores.FirstOrDefault(a => a.Id == id);
            return contexto.Livros.Where(l => l.Autor.Id == autor.Id).ToList();
        }

        public void Incluir(Autor autor)
        {
            contexto.Autores.Add(autor);
            contexto.SaveChanges();
        }

        public void Deletar(Autor autor)
        {
            contexto.Autores.Remove(autor);
            contexto.SaveChanges();
        }

        public bool VerificaSeOAutorExiste(int id)
        {
            return contexto.Autores.Count(a => a.Id== id) > 0;
        }

        public void Alterar(Autor autor)
        {
            contexto.Entry(autor).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
