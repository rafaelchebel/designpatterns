using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.SolicitacaoResposta
{
    public interface IResposta
    {
        //IResposta OutraResposta { get; set; }

        void Responde(Requisicao req, Conta conta);
    }
}
