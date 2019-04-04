using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder
{
    class NotaFiscalBuilder
    {
        private String RazaoSocial { get; set; }
        private String Cnpj { get; set; }
        private List<ItemDaNota> TodosItens = new List<ItemDaNota>();
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private String Observacoes { get; set; }
        private DateTime Data { get; set; }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto,
                                Impostos, TodosItens, Observacoes);
        }
    }
}
