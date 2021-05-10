using Desafio.CaiqueNeves.Ajudantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Desafio.CaiqueNeves.Entidade;

namespace Desafio.CaiqueNeves.Controlador
{
    public class ControladorListaProdutos : IControladorListaProdutos
    {
        private readonly ParserArquivoListaProdutos _parserArquivoListaProdutos;

        public ControladorListaProdutos(ParserArquivoListaProdutos parserArquivoListaProdutos)
        {
            _parserArquivoListaProdutos = parserArquivoListaProdutos;
        }


        /// <summary>
        ///  Metodo que vai retornar o produtos contidos no arquivo 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Retornar um objeto com os dados do produto</returns>
        public ListaProduto RetornarListaProduto(string path)
        {
            return _parserArquivoListaProdutos.LeituraArquivoProduto(path);
        }
    }
}
