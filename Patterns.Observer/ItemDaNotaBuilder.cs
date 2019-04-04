using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    class ItemDaNotaBuilder
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(String descricao)
        {
            this.Descricao = descricao;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}
