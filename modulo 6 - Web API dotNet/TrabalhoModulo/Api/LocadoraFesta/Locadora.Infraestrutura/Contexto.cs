using Locadora.Infraestrutura.Entidades;
using Locadora.Infraestrutura.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=Conection")
        { }

        public DbSet<Cliente> Autores { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pacote> Pacote { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<locacao> Locacao { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new PacoteMap());
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new LocacaoMap());
        }
    }
}
