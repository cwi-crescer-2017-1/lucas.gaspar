using EditoraCrescer.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescer.Infraestrutura.Repositorios
{
    public class LivroRepositorio
    {
        private Contexto contexto = new Contexto(); 
        public List<Livro> Obter()
        {
            return contexto.Livros.ToList();
        }

        public Livro ObterPorId(int id)
        {
            return contexto.Livros.FirstOrDefault(l => l.Isbn == id);
        }

        public IEnumerable<Livro> ObterPorGenero(string genero)
        {
            var lista = contexto.Livros.Where(l => l.Genero.Contains(genero));
            return lista;   
        }

        public void Incluir(Livro livro)
        {
            contexto.Livros.Add(livro);
            contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro livroASerRemovido = contexto.Livros.FirstOrDefault(l => l.Isbn == id);
            contexto.Livros.Remove(livroASerRemovido);
            contexto.SaveChanges();
        }

        public void Alterar(int id, Livro livro)
        {
            contexto.Entry(livro);
        }
    }
}
