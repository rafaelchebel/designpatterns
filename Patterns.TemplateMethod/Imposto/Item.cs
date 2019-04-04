﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod.Imposto
{
    public class Item
    {
        public string Nome { get; set; }

        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
