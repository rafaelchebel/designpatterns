using System;
using Patterns.State.EstadoOrcamento;
using Patterns.State.FiltroConta;

namespace Patterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estado Orçamento
            Orcamento reforma = new Orcamento(500.0);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
            reforma.Aprova(); // aprova nota!

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

            reforma.Finaliza();

            //reforma.AplicaDescontoExtra();// lancaria excecao, pois não pode dar desconto nesse estado
            //reforma.Aprova(); //lança exceção, pois não pode ir para aprovado

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();


            //Filtro da conta bancária
            Conta conta = new Conta();

            conta.Estado = new Positivo();
            conta.Deposita(100);
            Console.WriteLine($"Saldo: {conta.Saldo}");

            conta.Saca(35);
            Console.WriteLine($"Saldo: {conta.Saldo}");

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
