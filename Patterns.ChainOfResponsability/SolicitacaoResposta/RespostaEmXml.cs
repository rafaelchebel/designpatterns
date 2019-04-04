using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.SolicitacaoResposta
{
    class RespostaEmXml : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmXml(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmXml()
        {
            this.OutraResposta = null; // nao recebi a proxima!
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine($"<conta><titular>{conta.Titular}</titular><saldo>{conta.Saldo}</saldo></conta>");
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {
                // não existe próxima na corrente, e ninguém atendeu a requisição!
                // poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
