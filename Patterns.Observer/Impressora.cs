using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    public class Impressora : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("imprimindo notaFiscal");
        }
    }
}
