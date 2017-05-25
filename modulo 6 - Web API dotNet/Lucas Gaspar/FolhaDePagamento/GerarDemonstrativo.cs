using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
{
    public class GerarDemonstrativo: IFolhaPagamento
    {
        public int HorasCategoria { get; private set; }
        public double SalarioBase { get; private set; }
        public double HorasExtras { get; private set; }
        public double HorasDescontadas { get; private set; }

        public GerarDemonstrativo(int horasCategoria, double salarioBase, double horasExtras, double horasDescontadas)
        {
            HorasCategoria = horasCategoria;
            SalarioBase = salarioBase;
            HorasExtras = horasExtras;
            HorasDescontadas = horasDescontadas;
        }

         public Demonstrativo gerarDemonstrativo()
        {
            var HorasExtrasValor = HorasExtras * (SalarioBase / HorasCategoria);
            var HorasDescontadasValor = HorasDescontadas * (SalarioBase / HorasCategoria);
            HorasCalculadas h1 = new HorasCalculadas(SalarioBase / HorasCategoria, SalarioBase + HorasExtrasValor - HorasDescontadasValor);
            double TotalProventos = h1.calcularTotalProvento();
            double AliquotaInss;
            if (TotalProventos<=1000)
            {
                AliquotaInss = 8;
            }
            else if (TotalProventos <= 1500)
            {
                AliquotaInss = 9;
            }
            else
            {
                AliquotaInss = 10;
            }

            Desconto d1 = new Desconto(AliquotaInss, TotalProventos);
            double Inss = d1.CalcularInss();
            double AliquotaIRRF;
            if(TotalProventos<= 1710.80)
            {
                AliquotaIRRF = 0;
            }
            else if (TotalProventos <= 2563.91)
            {
                AliquotaIRRF = 7.5;
            }
            else if(TotalProventos <= 3418.59)
            {
                AliquotaIRRF = 15;
            }
            else if(TotalProventos <= 4271.59)
            {
                AliquotaIRRF = 22.5;
            }
            else
            {
                AliquotaIRRF = 27.5;
            }

            double irrf = Math.Truncate(100*d1.CalcularIrrf(TotalProventos - Inss, AliquotaIRRF))/100;

            double TotalDescontos = irrf + Inss;

            double TotalLiquido = TotalProventos - TotalDescontos;

            double fgts = TotalProventos * 0.11;

            Demonstrativo d = new Demonstrativo(SalarioBase, HorasCategoria, HorasExtrasValor, HorasDescontadasValor,
                   TotalProventos, Inss, irrf, TotalDescontos, TotalLiquido, fgts);

            return d;
        }
    }
}
