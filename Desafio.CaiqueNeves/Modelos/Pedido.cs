using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Entidade
{
    public class Pedido
    {
        public int Id { get; set; }

        public int QuantidadeItens { get; set; }

        public List<string> ListaProdutos { get; set; }

       
    }
}
