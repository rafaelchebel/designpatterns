using System;

namespace Patterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new EnviadorDeEmail());
            builder.AdicionaAcao(new NotaFiscalDao());

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .ComItem(new ItemDaNota("item 1", 100.0))
                              .ComItem(new ItemDaNota("item 2", 200.0))
                              .ComItem(new ItemDaNota("item 3", 300.0))
                              .ComObservacoes("entregar notaFiscal pessoalmente")
                              .NaDataAtual()
                              .Constroi();

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
