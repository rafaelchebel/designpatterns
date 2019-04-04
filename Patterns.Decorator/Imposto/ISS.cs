using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator.Imposto
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public ISS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            var valorISS = orcamento.Valor * 0.06;
            var valorAcumulado = valorISS + CalculoDoOutroImposto(orcamento);

            Console.WriteLine($"ISS: {valorISS}");

            return valorAcumulado;
        }
    }
}
