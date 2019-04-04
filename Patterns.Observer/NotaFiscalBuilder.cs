using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    class NotaFiscalBuilder
    {
        public String RazaoSocial { set; get; }
        public String Cnpj { set; get; }
        public double ValorTotal { set; get; }
        public double Impostos { set; get; }
        public DateTime Data { set; get; }
        public String Observacoes { set; get; }

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas;

        public NotaFiscalBuilder()
        {
            this.todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this; // retorno eu mesmo, o próprio builder, para que o cliente continue utilizando
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
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
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal,
                                            Impostos, todosItens, Observacoes);

            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }
    }
}
