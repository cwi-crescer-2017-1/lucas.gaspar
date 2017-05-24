using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Informe o peso");
            var entradaPeso = Console.ReadLine();

            var pesoTeste = 0D;

            if (!double.TryParse(entradaPeso, out pesoTeste))
            {
                Console.WriteLine("Entrada de peso inválida");          
            }

            Console.WriteLine("Informe a altura");
            var entradaAltura = Console.ReadLine();

            var peso = double.Parse(entradaPeso);
            var altura = double.Parse(entradaAltura);

            var calculoImc = new Calculo(altura, peso);
            var imc = calculoImc.calcularImc();

            Console.WriteLine("Seu imc é " +imc);
            Console.ReadKey();*/

            List<int> array = new List<int>();
            Boolean continua = true;

            while (continua == true)
            {
                Console.WriteLine("Digite Um valor");
                var entrada = Console.ReadLine();

                if (entrada == "exit")
                {
                    break;
                }

                array.Add(int.Parse(entrada));

            }

            foreach (var a in array)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
