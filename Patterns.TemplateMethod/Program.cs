using System;
using System.Collections.Generic;
using Patterns.TemplateMethod.Imposto;
using Patterns.TemplateMethod.Relatorio;

namespace Patterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto ihit = new IHIT();
            IImposto ikcv = new IKCV();
            IImposto icpp = new ICPP();

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS
            calculador.RealizaCalculo(orcamento, icms);

            // Calculando o IHIT
            calculador.RealizaCalculo(orcamento, ihit);

            // Calculando o IKCV
            calculador.RealizaCalculo(orcamento, ikcv);

            // Calculando o ICPP
            calculador.RealizaCalculo(orcamento, icpp);

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();


            //Relatorio
            IList<Conta> contaList = new List<Conta>();
            contaList.Add(new Conta("Josivaldo", 123, 321, 459));
            contaList.Add(new Conta("Rosemari", 456, 654, 12378));
            contaList.Add(new Conta("Marinalva", 890, 098, 66789));

            RelatorioSimples relatorioSimples = new RelatorioSimples();
            Console.WriteLine("\n--- Relatório Simples ---");
            relatorioSimples.Imprime(contaList);

            RelatorioComplexo relatorioComplexo = new RelatorioComplexo();
            Console.WriteLine("\n--- Relatório Complexo ---");
            relatorioComplexo.Imprime(contaList);

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
