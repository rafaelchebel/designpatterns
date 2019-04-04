using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.Desconto
{
    class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public DescontoPorCincoItens(IDesconto proximo)
        {
            this.Proximo = proximo;
        }

        public DescontoPorCincoItens()
        {
            //Não recebe nenhum desconto
            this.Proximo = null;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;
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
