using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod.Relatorio
{
    public class Conta
    {
        public String Nome { get; private set; }
        public int Numero { get; private set; }
        public int Agencia { get; private set; }
        public double Saldo { get; private set; }

        public Conta(String nome, int numero, int agencia, double saldo)
        {
            this.Nome = nome;
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = saldo;
        }
    }
}
