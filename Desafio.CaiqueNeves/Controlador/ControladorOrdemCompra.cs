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
        public OrdemCompra LeituraArquivoOrdemCompra(string path)
        {
            try
            {
                Console.WriteLine("\n " + Constantes.TIPO_MENSAGEM_INICIO_LEITURA_ARQUIVO+" Ordem Compra. \n");

                if (String.IsNullOrEmpty(path))
                {
                    new Exception(Constantes.TIPO_MENSAGEM_ARQUIVO_VAZIO+" Ordem Compra. ");
                }

                var dadosArquivos = Util.LerArquivo(path);
                var ordemCompra = new OrdemCompra();
                var listaPedidos = new List<Pedido>();
                string dadosDoPedido = "";
                int quantidadeItensPedido = 0;


                if (dadosArquivos.Any())
                {
                    ordemCompra.NumeroPedidosCompra = Convert.ToInt32(dadosArquivos[0]);
                    
                    for (int i = 1; i <= dadosArquivos.Count() - 1; i++)
                    {
                        dadosDoPedido += dadosArquivos[i] + "_";

                        // Identificar posicao que começar a descrição dos pedidos
                        if (dadosArquivos[i].Length > 1)
                        {
                            if (quantidadeItensPedido == 0)
                            {
                                // Pegar quantidade de pedidos por itens
                                quantidadeItensPedido = Convert.ToInt32(dadosArquivos[i - 1]);
                            }

                            AtribuiPedidosOrdemCompra(listaPedidos, ref dadosDoPedido, ref quantidadeItensPedido);
                        }
                    }

                    ordemCompra.pedidos = listaPedidos;
                }

                Console.WriteLine("\n " + Constantes.TIPO_MENSAGEM_FIM_LEITURA_ARQUIVO+" Ordem Compra. \n");

                return ordemCompra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void AtribuiPedidosOrdemCompra(List<Pedido> listaPedidos, ref string dadosDoPedido, ref int quantidadeItensPedido)
        {
            string[] arrayDadosPedido = dadosDoPedido.Split('_');
            var QtdInfor = arrayDadosPedido.Length;

            if ((QtdInfor - 1) == (quantidadeItensPedido + 2))
            {
                var pedido = new Pedido();
                pedido.Id = Convert.ToInt32(arrayDadosPedido[0]);
                pedido.QuantidadeItens = quantidadeItensPedido;

                List<string> listaDescricaoProdutos = new List<string>();
                for (int a = 2; a < arrayDadosPedido.Length - 1; a++)
                {
                    listaDescricaoProdutos.Add(arrayDadosPedido[a]);
                }

                pedido.ListaNomeProdutos = listaDescricaoProdutos;
                quantidadeItensPedido = 0;
                dadosDoPedido = "";

                listaPedidos.Add(pedido);

            }
        }
    }
}
