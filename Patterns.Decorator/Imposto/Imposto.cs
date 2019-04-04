using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator.Imposto
{
    public abstract class Imposto
    {
        private readonly Imposto OutroImposto;

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        // construtor default
        public Imposto()
        {
            this.OutroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
