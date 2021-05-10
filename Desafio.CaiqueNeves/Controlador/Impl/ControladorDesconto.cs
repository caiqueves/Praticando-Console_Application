using Desafio.CaiqueNeves.Ajudantes;
using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;


namespace Desafio.CaiqueNeves.Controlador
{
   public class ControladorDesconto : IControladorDesconto
    {
        private readonly ParserArquivoDesconto _parserArquivoDesconto;

       
        public ControladorDesconto(ParserArquivoDesconto parserArquivoDesconto)
        {
            this._parserArquivoDesconto = parserArquivoDesconto;
        }


        /// <summary>
        ///  Metodo que vai retornar os desconto contidos no arquivo 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Retornar uma lista de descontos</returns>
        public List<Desconto> RetornarListaDesconto(string path)
        {
            return _parserArquivoDesconto.LeituraListaDesconto(path); 
        }

    }
}
