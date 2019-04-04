using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsability.Desconto
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public IList<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
        }
    }
}
