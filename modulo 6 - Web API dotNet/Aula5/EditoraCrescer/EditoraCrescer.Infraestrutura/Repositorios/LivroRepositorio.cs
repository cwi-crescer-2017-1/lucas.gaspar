using EditoraCrescer.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescer.Infraestrutura.Repositorios
{
    public class LivroRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto(); 
        public object Obter()
        {
            return contexto.Livros.Select(l => new
            {
                Isbn = l.Isbn,
                Titulo = l.Titulo,
                Capa = l.Capa,
                NomeAutor = l.Autor.Nome,
                Genero = l.Genero
            }).ToList();
        }

        public Livro ObterPorId(int isbn)
        {
            return contexto.Livros.Include(l => l.Autor).Include(l => l.Revisor).FirstOrDefault(l => l.Isbn == isbn);
        }

        public object ObterPorGenero(string genero)
        {
            var lista = contexto.Livros.Where(l => l.Genero.Contains(genero));
            var listaResumida = lista.Select(l => new
            {
                Isbn = l.Isbn,
                Titulo = l.Titulo,
                Capa = l.Capa,
                NomeAutor = l.Autor.Nome,
                Genero = l.Genero
            });
            return listaResumida;   
        }

        public object ObterLancamentos()
        {
            var diaAtualMenosUmaSemana = DateTime.Today.AddDays(-7);
            var lista = contexto.Livros.Where(l => l.DataPublicacao >= diaAtualMenosUmaSemana);
            var listaResumida = lista.Select(l => new
            {
                Isbn = l.Isbn,
                Titulo = l.Titulo,
                Capa = l.Capa,
                NomeAutor = l.Autor.Nome,
                Genero = l.Genero
            });
            return listaResumida;
        }

        public void Incluir(Livro livro)
        {
            contexto.Livros.Add(livro);
            contexto.SaveChanges();
        }

        public void Deletar(Livro livro)
        {
            contexto.Livros.Remove(livro);
            contexto.SaveChanges();
        }

        public Livro Alterar(Livro livro)
        {
            contexto.Entry(livro).State = EntityState.Modified;
            contexto.SaveChanges();
            return livro;
        }

        public bool VerificaSeOLivroExiste(int isbn)
        {
            return contexto.Livros.Count(e => e.Isbn == isbn) > 0;
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
