using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.Desconto
{
    public class CalculadorDeDescontos
    {
        //Forma errada de se implementar
        //public double Calcula(Orcamento orcamento)
        //{
        //    // vai chamando os descontos na ordem até que algum deles dê diferente de zero...
        //    double desconto = new DescontoPorCincoItens().Desconta(orcamento);
        //    if (desconto == 0)
        //        desconto = new DescontoPorMaisDeQuinhentosReais().Desconta(orcamento);
        //    if (desconto == 0)
        //        desconto = new ProximoDesconto().Desconta(orcamento);
        //    // ...

        //    return desconto;
        //}

        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();

            d1.Proximo = d2;

            return d1.Desconta(orcamento);
        }
    }
}
