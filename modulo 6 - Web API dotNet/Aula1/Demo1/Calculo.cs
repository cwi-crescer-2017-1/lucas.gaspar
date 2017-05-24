using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Calculo
    {
        public double Altura { get; set; }
        public double Peso { get; set; }

        public Calculo(double altura, double peso)
        {
            Altura = altura;
            Peso = peso;
        }

        public Double calcularImc()
        {
            return Peso / (Altura * Altura);
        }
    }
}
