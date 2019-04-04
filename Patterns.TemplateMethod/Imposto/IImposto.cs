using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod.Imposto
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
