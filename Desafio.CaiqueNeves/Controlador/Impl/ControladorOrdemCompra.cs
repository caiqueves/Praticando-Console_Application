using Desafio.CaiqueNeves.Ajudantes;
using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Controlador
{
    public class ControladorOrdemCompra : IControladorOrdemCompra
    {
        private readonly ParserArquivoOrdemCompra _parserArquivoOrdemCompra;

        public ControladorOrdemCompra(ParserArquivoOrdemCompra parserArquivoOrdemCompra)
        {
            _parserArquivoOrdemCompra = parserArquivoOrdemCompra;
        }

        public OrdemCompra RetornarListaOrdemCompra(string path)
        {
            return _parserArquivoOrdemCompra.LeituraArquivoOrdemCompra(path);
        }
    }
}
