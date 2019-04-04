using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod.Relatorio
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("\nCabeçalho: Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("\nRodapé: (11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            Console.WriteLine("\nCorpo:");
            foreach (Conta c in contas)
            {
                Console.WriteLine($"Nome: {c.Nome} - Número: {c.Numero}");
            }
        }
    }
}
