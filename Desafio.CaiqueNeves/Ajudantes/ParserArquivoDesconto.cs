using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Ajudantes
{
    public class ParserArquivoDesconto
    {
        /// <summary>
        ///  Metodo que vai ser responsavel por encapsular os dados do arquivo em lista de objetos
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Vai retornar uma lista de objetos "Desconto"</returns>

        public List<Desconto> LeituraListaDesconto(string path)
        {
            try
            {
                Console.WriteLine("\n " + Constantes.TIPO_MENSAGEM_INICIO_LEITURA_ARQUIVO + " desconto. \n");

                if (String.IsNullOrEmpty(path))
                {
                    new Exception(Constantes.TIPO_MENSAGEM_ARQUIVO_VAZIO + " desconto");
                }

                var listaDescontos = new List<Desconto>();

                var dadosArquivos = Util.LerArquivo(path);
                var index = 0;
                List<string> valores = null;

                if (dadosArquivos.Any())
                {
                    for (int i = 0; i < dadosArquivos.Count(); i++)
                    {
                        valores.Add(dadosArquivos[i]);
                        index += 1;

                        if (index == 4)
                        {
                            var desconto = new Desconto(valores[1], Convert.ToInt32(valores[0]),
                                Convert.ToInt32(valores[2]), Convert.ToInt32(valores[3]));
                            index = 0;
                            valores = null;
                            listaDescontos.Add(desconto);
                        }
                    }
                }

                Console.WriteLine("\n " + Constantes.TIPO_MENSAGEM_FIM_LEITURA_ARQUIVO + " desconto. \n");

                return listaDescontos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
