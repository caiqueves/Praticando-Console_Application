using Desafio.CaiqueNeves.Ajudantes;
using Desafio.CaiqueNeves.Entidade;
using System.Collections.Generic;


namespace Desafio.CaiqueNeves.Controlador
{
    public class ControladorDesconto
    {
        
        /// <summary>
        ///  Metodo que vai retornar os desconto contidos no arquivo 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Retornar uma lista de descontos</returns>
        public List<Desconto> RetornarListaDesconto(string path)
        {
            ParserArquivoDesconto _parserArquivoDesconto = new ParserArquivoDesconto();
            return _parserArquivoDesconto.LeituraListaDesconto(path); 
        }

    }
}
