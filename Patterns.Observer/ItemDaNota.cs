using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    public class ItemDaNota
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(String descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
