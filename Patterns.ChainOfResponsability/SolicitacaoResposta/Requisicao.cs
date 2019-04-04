using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.SolicitacaoResposta
{
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
    }
}
