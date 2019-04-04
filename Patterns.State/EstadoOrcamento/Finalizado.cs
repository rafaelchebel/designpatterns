using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.State.EstadoOrcamento
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento está finalizado!");
        }
    }
}
