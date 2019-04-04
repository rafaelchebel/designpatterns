using Patterns.Decorator.Imposto;
using System;

namespace Patterns.Decorator
{
    class Program
    {
        static void Main(String[] args)
        {
            Patterns.Decorator.Imposto.Imposto imposto = new ISS(new ICMS(new IKCV()));

            Orcamento orcamento = new Orcamento(500.0);

            double valor = imposto.Calcula(orcamento);

            Console.WriteLine($"Total de Impostos: {valor}");

            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
