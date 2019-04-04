using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.State.FiltroConta
{
    public class Conta
    {
        public double Saldo { get; set; }
        public EstadoDaConta Estado;

        public void Saca(double valor)
        {
            Console.WriteLine($"Sacando {valor} reais.");
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Console.WriteLine($"Depositando {valor} reais.");
            Estado.Deposita(this, valor);
        }
    }
}
