using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Entidade
{
    public class Fatura
    {
        public int NumeroFatura { get; set; }
        public List<DetalheFatura> DetalheFaturas { get; set; }
    }
}
