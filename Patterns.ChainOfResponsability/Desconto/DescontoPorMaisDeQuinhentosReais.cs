using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.Desconto
{
    class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public DescontoPorMaisDeQuinhentosReais(IDesconto proximo)
        {
            this.Proximo = proximo;
        }

        public DescontoPorMaisDeQuinhentosReais()
        {
            //Não recebe nenhum desconto
            this.Proximo = null;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return orcamento.Valor * 0.07;
            else if (Proximo != null)
                return Proximo.Desconta(orcamento);
            else
            {
                // não existe próxima na corrente, e ninguém atendeu a requisição!
                // poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
