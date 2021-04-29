using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Controlador
{
    public class ControladorFatura
    {
        public Fatura RetornarFaturas(ListaProduto listaProduto, List<Desconto> listaDescontos,OrdemCompra OrdemCompras)
        {
            try
            {
                var fatura = new Fatura();

                if ((listaProduto != null) && (listaDescontos.Any()) && (OrdemCompras != null))
                {
                    Console.WriteLine("Começou a geração da fatura. \n");

                    var listaDetalhes = new List<DetalheFatura>();

                    fatura.NumeroFatura = OrdemCompras.NumeroPedidosCompra;

                    for (int c = 0; c < OrdemCompras.NumeroPedidosCompra; c++)
                    {
                        var pedido = OrdemCompras.pedidos[c];

                        var detalheFatura = new DetalheFatura();
                        detalheFatura.Id_Pedido = pedido.Id;
                        detalheFatura.QuantidadeItens_Pedido = pedido.QuantidadeItens;
                        detalheFatura.TotalFatura = calcularTotalFatura(listaProduto, listaDescontos, pedido); 
                        listaDetalhes.Add(detalheFatura);
                    }

                    fatura.DetalheFaturas = listaDetalhes;
                    Console.WriteLine("Terminou a geração da fatura \n\n");

                }
                return fatura;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static int calcularTotalFatura(ListaProduto listaProduto, List<Desconto> listaDescontos, Pedido pedido)
        {
            var produtosItens = pedido.ListaNomeProdutos.Distinct();
            var totalFaturaPar = 0;

            foreach (var item in produtosItens)
            {
                var produto = new Produto();
                produto = (Produto)listaProduto.Produtos.FirstOrDefault(pr => pr.Nome == item);

                // Verificacao caso a ordem de compra tenha produto que não existe na lista de produto
                if (produto != null)
                {
                    int quantidade = pedido.ListaNomeProdutos.Count(f => f == item);

                    var desconto = new Desconto();
                    desconto = listaDescontos.FirstOrDefault(b => b.NomeProduto == item);

                    if ((desconto != null) && (desconto.QuantidadeItemPedido == quantidade))
                    {
                        totalFaturaPar += desconto.QuantidadeItemCobrado * produto.Preco;
                    }
                    else
                    {
                        totalFaturaPar += quantidade * produto.Preco;
                    }
                }
            }

            return totalFaturaPar;
        }


        public int GravarArquivo(Fatura fatura, string path)
        {
            try
            {
                Console.WriteLine("\n Começou a exportação da fatura para um arquivo \n");

                Directory.CreateDirectory(path);

                string pathArquivo = path + "\\" + "invoices.txt";

                if (File.Exists(pathArquivo))
                {
                    File.Delete(pathArquivo);
                }

                using (StreamWriter writer = new StreamWriter(pathArquivo,true))
                {
                    writer.WriteLine(fatura.NumeroFatura);

                    foreach (var item in fatura.DetalheFaturas)
                    {
                        writer.WriteLine(item.Id_Pedido);
                        writer.WriteLine(item.QuantidadeItens_Pedido);
                        writer.WriteLine(item.TotalFatura);

                    }
                    writer.Close();
                }

                Console.WriteLine("\n Terminou a exportação da fatura para verificar o arquivo acesse o local:");
                Console.WriteLine(pathArquivo);

                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
