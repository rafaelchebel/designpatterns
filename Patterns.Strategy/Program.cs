using System;

namespace Patterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);

            Console.ReadKey();
        }
    }
}
