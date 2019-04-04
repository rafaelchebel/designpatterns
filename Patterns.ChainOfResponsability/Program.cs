using System;
using Patterns.ChainOfResponsability.Desconto;
using Patterns.ChainOfResponsability.SolicitacaoResposta;

namespace Patterns.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desconto
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lápis", 250));
            orcamento.AdicionaItem(new Item("Estojo", 700));
            orcamento.AdicionaItem(new Item("Borracha", 10));
            orcamento.AdicionaItem(new Item("Lapiseira", 500));
            orcamento.AdicionaItem(new Item("Mochila", 1200));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(string.Format("Desconto: {0}", desconto));

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();


            //SolicitacaoResposta
            SolicitaResposta solicitaResposta = new SolicitaResposta();
            solicitaResposta.Resposta(new Conta("Jociclei", 5000), new Requisicao(Formato.XML));

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
