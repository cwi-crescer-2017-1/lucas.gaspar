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
    class EmpregadoMap : EntityTypeConfiguration<Empregado>
    {
        public EmpregadoMap()
        {
            ToTable("Empregado");
        }
    }
}
