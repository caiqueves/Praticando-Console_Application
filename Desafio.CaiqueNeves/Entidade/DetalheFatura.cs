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
    }
}
