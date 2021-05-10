using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.CaiqueNeves.Entidade
{
    public class Desconto : Produto
    {
       

        public int NumeroDesconto { get; set; }
        public int QuantidadeItemPedido { get; set; }
        public int QuantidadeItemCobrado { get; set; }

        public Desconto ()
        {

        }
        public Desconto(string NomeProduto, int NumeroDesconto, int QuantidadeItemPedido, int QuantidadeItemCobrado)
        {
            this.Nome = NomeProduto;
            this.NumeroDesconto = NumeroDesconto;
            this.QuantidadeItemPedido = QuantidadeItemPedido;
            this.QuantidadeItemCobrado = QuantidadeItemCobrado;
        }

    }
}
