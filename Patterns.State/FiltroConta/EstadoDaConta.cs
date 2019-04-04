using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.State.FiltroConta
{
    public interface EstadoDaConta
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);
    }
}
