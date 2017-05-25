﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
{
    public class Demonstrativo
    {
        public Demonstrativo(
            double salarioBase,
            double hrsConvencao,
            double horasExtras,
            double horasDescontadas,
            double totalProventos,
            double inss,
            double irrf,
            double totalDescontos,
            double totalLiquido,
            double fgts)
        {
            SalarioBase = salarioBase;
            HrsConvencao = hrsConvencao;
            HorasExtras = horasExtras;
            HorasDescontadas = horasDescontadas;
            TotalProventos = totalProventos;
            Inss = inss;
            Irrf = irrf;
            TotalDescontos = totalDescontos;
            TotalLiquido = totalLiquido;
            Fgts = fgts;
        }

        public double SalarioBase { get; private set; }
        public double HrsConvencao { get; private set; }
        public double HorasExtras { get; private set; }
        public double HorasDescontadas { get; private set; }
        public double TotalProventos { get; private set; }
        public double Inss { get; private set; }
        public double Irrf { get; private set; }
        public double TotalDescontos { get; private set; }
        public double TotalLiquido { get; private set; }
        public double Fgts { get; private set; }

    }
}
