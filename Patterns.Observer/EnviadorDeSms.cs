using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por sms");
        }
    }
}
