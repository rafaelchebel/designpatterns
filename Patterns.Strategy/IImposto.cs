using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
