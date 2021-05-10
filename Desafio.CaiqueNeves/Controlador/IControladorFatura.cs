using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Controlador
{
   public interface IControladorFatura
    {
        int GravarFatura(ListaProduto listaProduto, List<Desconto> listaDescontos, OrdemCompra OrdemCompras, string path);
    }
}
