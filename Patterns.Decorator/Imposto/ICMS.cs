using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator.Imposto
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public ICMS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            var valorICMS = orcamento.Valor * 0.01;
            var valorAcumulado = valorICMS + CalculoDoOutroImposto(orcamento);

            Console.WriteLine($"ICMS: {valorICMS}");

            return valorAcumulado;
        }
    }
}
