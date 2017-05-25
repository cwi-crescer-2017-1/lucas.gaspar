using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
{
    public class Desconto
    {
        public Desconto(double aliquota, double valor)
        {
            Aliquota = aliquota;
            Valor = valor;
        }

        public double Aliquota { get; private set; }
        public double Valor { get; private set; }

        public double CalcularInss()
        {
            return Valor * (Aliquota / 100);
        }
        public double CalcularIrrf(double TotalProventos, double AliquotaUrrf)
        {
            return TotalProventos * (AliquotaUrrf / 100);
        }
    }
}
