using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator.Imposto
{
    class IKCV : Imposto
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        public IKCV() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            var valorIKCV = orcamento.Valor * 0.03;
            var valorAcumulado = valorIKCV + CalculoDoOutroImposto(orcamento);

            Console.WriteLine($"IKCV: {valorIKCV}");

            return valorAcumulado;
        }
    }
}
