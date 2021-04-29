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
    public class ControladorListaProdutos
    {
        /// <summary>
        ///  Metodo que vai ser responsavel por encapsular os dados do arquivo em lista de objetos
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Vai retornar um objeto "ListaProduto"</returns>
        public ListaProduto LeituraArquivoProduto(string path)
        {
            try
            {
                Console.WriteLine("\n " + Constantes.TIPO_MENSAGEM_INICIO_LEITURA_ARQUIVO+" de Produto. \n");

                if (String.IsNullOrEmpty(path))
                {
                    new Exception(Constantes.TIPO_MENSAGEM_ARQUIVO_VAZIO+ "  de Produto. ");
                }

                var ListaProduto = new ListaProduto();
                var dadosArquivos = Util.LerArquivo(path);
                var produtos = new List<Produto>();
                var index = 0;

                if (dadosArquivos.Any())
                {
                    ListaProduto.NumeroProdutos = Convert.ToInt32(dadosArquivos[0]);

                    for (int i = 1; i <= dadosArquivos.Count() - 1; i++)
                    {
                        index += 1;

                        if (index == 2)
                        {
                            var produto = new Produto();
                            produto.Nome = dadosArquivos[i - 1];
                            produto.Preco = Convert.ToInt32(dadosArquivos[i]);
                            produtos.Add(produto);
                            index = 0;
                        }
                    }

                    ListaProduto.Produtos = produtos;
                }

                Console.WriteLine("\n " + Constantes.TIPO_MENSAGEM_FIM_LEITURA_ARQUIVO+" de Produto. \n");

                return ListaProduto;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
