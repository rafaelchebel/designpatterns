using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod.Relatorio
{
    class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("\nCabeçalho:");
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Rodape()
        {
            Console.WriteLine("\nRodapé:");
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            Console.WriteLine("\nCorpo:");
            foreach (Conta c in contas)
            {
                Console.WriteLine($"Nome: c.Nome - Número: {c.Numero} - Agência: {c.Agencia} - Saldo: {c.Saldo}");
            }
        }
    }
}
