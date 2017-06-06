using Locadora.Dominio;
using Locadora.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Mappings
{
    class LocacaoMap : EntityTypeConfiguration<Locacao>
    {
        public LocacaoMap()
        {
            ToTable("Locacao");

            HasRequired(x => x.Cliente)
                .WithMany()
                .Map(x => x.MapKey("IdCliente"));

            HasRequired(x => x.Produto)
                .WithMany()
                .Map(x => x.MapKey("IdProduto"));

            HasRequired(x => x.Pacote)
                .WithMany()
                .Map(x => x.MapKey("IdPacote"));

            HasMany(x => x.Item)
                .WithMany()
                .Map(x =>
                {
                    x.MapLeftKey("IdLocacao");
                    x.MapRightKey("IdItem");
                    x.ToTable("ItemLocacao");
                });

        }
    }
}
