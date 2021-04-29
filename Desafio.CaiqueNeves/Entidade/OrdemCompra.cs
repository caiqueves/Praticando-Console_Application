using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.CaiqueNeves.Entidade
{
    public class OrdemCompra
    {
        public int NumeroPedidosCompra { get; set; }
        public List<Pedido> pedidos { get; set; }
    }
}
