using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.Desconto
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Desconta(Orcamento orcamento);
    }
}
