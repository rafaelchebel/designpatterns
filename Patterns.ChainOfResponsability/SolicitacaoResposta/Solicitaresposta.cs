using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.SolicitacaoResposta
{
    public class SolicitaResposta
    {
        public void Resposta(Conta conta, Requisicao requisicao)
        {
            new RespostaEmCsv(
                new RespostaEmPorcento(
                    new RespostaEmXml()
                )
            ).Responde(requisicao, conta);
        }
    }
}
