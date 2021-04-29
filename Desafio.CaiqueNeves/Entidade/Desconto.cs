using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.CaiqueNeves.Entidade
{
    public class Desconto
    {
        public int NumeroDesconto { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeItemPedido { get; set; }
        public int QuantidadeItemCobrado { get; set; }
    }
}
