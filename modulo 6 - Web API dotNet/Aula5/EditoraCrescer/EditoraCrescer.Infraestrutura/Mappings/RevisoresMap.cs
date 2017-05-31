﻿using EditoraCrescer.Infraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescer.Infraestrutura.Mappings
{
    class RevisoresMap: EntityTypeConfiguration<Revisor>
    {
        public RevisoresMap()
        {
            ToTable("Revisores");
        }
    }
}
