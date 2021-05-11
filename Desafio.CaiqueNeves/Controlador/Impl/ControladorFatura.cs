using Desafio.CaiqueNeves.Ajudantes;
using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Desafio.CaiqueNeves.Controlador
{
    public class ControladorFatura
    {
        

        public int GravarFatura(ListaProduto listaProduto, List<Desconto> listaDescontos,OrdemCompra OrdemCompras, string path)
        {
            try
            {
                var fatura = new Fatura();

                if ((listaProduto != null) && (listaDescontos.Any()) && (OrdemCompras != null))
                {
                    Console.WriteLine("Começou a geração da fatura. \n");

                    var listaDetalhes = new List<DetalheFatura>();

                    fatura.NumeroFatura = OrdemCompras.NumeroPedidosCompra;

                    for (int c = 0; c < fatura.NumeroFatura; c++)
                    {
                        var pedido = OrdemCompras.pedidos[c];

                        int totalFatura = CalcularTotalFatura(listaProduto, listaDescontos, pedido);
                        var detalheFatura = new DetalheFatura(pedido.Id, pedido.QuantidadeItens, totalFatura);
                        
                        listaDetalhes.Add(detalheFatura);
                    }

                    fatura.DetalheFaturas = listaDetalhes;
                    Console.WriteLine("Terminou a geração da fatura \n\n");

                }
                Util.GravarArquivo(fatura, path);
                return 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static int CalcularTotalFatura(ListaProduto listaProduto, List<Desconto> listaDescontos, Pedido pedido)
        {
            var produtosItens = pedido.ListaProdutos.Distinct();
            var totalFaturaPar = 0;

            foreach (var item in produtosItens)
            {
                var produto = new Produto();
                produto = (Produto)listaProduto.Produtos.FirstOrDefault(pr => pr.Nome == item);

                // Verificacao caso a ordem de compra tenha produto que não existe na lista de produto
                if (produto != null)
                {
                    int quantidade = pedido.ListaProdutos.Count(f => f == item);

                    var desconto = new Desconto();
                    desconto = listaDescontos.FirstOrDefault(b => b.Nome == item);

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
    }
}
