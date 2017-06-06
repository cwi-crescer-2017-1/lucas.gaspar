using Locadora.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Mappings
{
    class LocacaoMap : EntityTypeConfiguration<locacao>
    {
        public LocacaoMap()
        {
            ToTable("Locacao");

            HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.IdCliente);

            HasRequired(x => x.Produto)
                .WithMany()
                .HasForeignKey(x => x.IdProduto);

            HasRequired(x => x.Pacote)
                .WithMany()
                .HasForeignKey(x => x.IdPacote);

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
