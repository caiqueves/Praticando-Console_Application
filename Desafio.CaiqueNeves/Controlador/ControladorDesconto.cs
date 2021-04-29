using Desafio.CaiqueNeves.Ajudantes;
using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Controlador
{
   public class ControladorDesconto
    {
        /// <summary>
        ///  Metodo que vai ser responsavel por encapsular os dados do arquivo em lista de objetos
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Vai retornar uma lista de objetos "Desconto"</returns>
        public List<Desconto> RetornarListaDesconto(string path)
        {
            try
            {
                Console.WriteLine("\n "+Constantes.TIPO_MENSAGEM_INICIO_LEITURA_ARQUIVO+" desconto. \n");

                if (String.IsNullOrEmpty(path))
                {
                    new Exception(Constantes.TIPO_MENSAGEM_ARQUIVO_VAZIO+" desconto");
                }

                var listaDescontos = new List<Desconto>();

                var dadosArquivos = Util.LerArquivo(path);
                var index = 0;
                var valores = "";

                if (dadosArquivos.Any())
                {
                    for (int i = 0; i < dadosArquivos.Count(); i++)
                    {
                        
                        valores += dadosArquivos[i] + "_";
                        index += 1;

                        if (index == 4)
                        {
                            string[] dadosDesconto = valores.Split('_');
                            var desconto = new Desconto();
                            desconto.NumeroDesconto = Convert.ToInt32(dadosDesconto[0]);
                            desconto.NomeProduto = dadosDesconto[1];
                            desconto.QuantidadeItemPedido = Convert.ToInt32(dadosDesconto[2]);
                            desconto.QuantidadeItemCobrado = Convert.ToInt32(dadosDesconto[3]);
                            listaDescontos.Add(desconto);
                            index = 0;
                            valores = "";
                        }

                    }
                }

                Console.WriteLine("\n "+Constantes.TIPO_MENSAGEM_FIM_LEITURA_ARQUIVO+" desconto. \n");

                return listaDescontos;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
