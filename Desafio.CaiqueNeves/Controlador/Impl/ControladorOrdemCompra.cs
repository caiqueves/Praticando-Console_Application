using Desafio.CaiqueNeves.Ajudantes;
using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Controlador
{
    public class ControladorOrdemCompra
    {
        
        public OrdemCompra RetornarOrdemCompra(string path)
        {
            ParserArquivoOrdemCompra _parserArquivoOrdemCompra = new ParserArquivoOrdemCompra();
            return _parserArquivoOrdemCompra.LeituraArquivoOrdemCompra(path);
        }
    }
}
