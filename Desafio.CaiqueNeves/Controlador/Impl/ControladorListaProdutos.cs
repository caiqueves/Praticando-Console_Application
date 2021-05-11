using Desafio.CaiqueNeves.Ajudantes;
using Desafio.CaiqueNeves.Entidade;

namespace Desafio.CaiqueNeves.Controlador
{
    public class ControladorListaProdutos
    {
        

        /// <summary>
        ///  Metodo que vai retornar o produtos contidos no arquivo 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Retornar um objeto com os dados do produto</returns>
        public ListaProduto RetornarListaProduto(string path)
        {
            ParserArquivoListaProdutos _parserArquivoListaProdutos = new ParserArquivoListaProdutos();
            return _parserArquivoListaProdutos.LeituraArquivoProduto(path);
        }
    }
}
