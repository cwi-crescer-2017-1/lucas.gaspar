using Locadora.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class LocacaoRepositorio
    {
        private Contexto contexto = new Contexto();

        public void IncluirLocacao(Locacao locacao)
        {
            var precoItens = 0.0;
            contexto.Entry(locacao.Produto).State = System.Data.Entity.EntityState.Unchanged;
            contexto.Entry(locacao.Pacote).State = System.Data.Entity.EntityState.Unchanged;
            contexto.Entry(locacao.Cliente).State = System.Data.Entity.EntityState.Unchanged;
            foreach (var i in locacao.Item)
            {
                contexto.Entry(i).State = System.Data.Entity.EntityState.Unchanged;
                precoItens = precoItens + i.Preco;
            }

            var preco = locacao.calcularPreco(locacao.Pacote.Preco, precoItens);
            locacao.PrecoTotal = preco;
            contexto.Locacao.Add(locacao);

            contexto.SaveChanges();
        }
    }
}
