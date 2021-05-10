using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Entidade
{
   public class DetalheFatura
    {
        public int Id_Pedido { get; set; }

        public int QuantidadeItens_Pedido { get; set; }

        public int TotalFatura { get; set; }

        public DetalheFatura(int id_Pedido, int quantidadeItens_Pedido, int totalFatura)
        {
            Id_Pedido = id_Pedido;
            QuantidadeItens_Pedido = quantidadeItens_Pedido;
            TotalFatura = totalFatura;
        }
    }
}
