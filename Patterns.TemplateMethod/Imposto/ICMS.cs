using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod.Imposto
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
