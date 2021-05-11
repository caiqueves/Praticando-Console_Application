using System;
using System.Collections.Generic;
using Desafio.CaiqueNeves.Entidade;
using Desafio.CaiqueNeves.Controlador;

namespace Desafio.CaiqueNeves
{
    public class Program
    {
        static ListaProduto listaProduto;
         static List<Desconto> listaDescontos;
         static OrdemCompra OrdemCompras;

        public static ControladorListaProdutos ControladorListaProdutos { get; }

        public static ControladorDesconto ControladorDesconto { get; }

        public static ControladorOrdemCompra ControladorOrdemCompra { get; }

        public static ControladorFatura ControladorFatura { get; }

        public static void Main(string[] args)
        {
            try
            {
                string cond = "executar";
                while (cond != "parar")
                {
                    Console.WriteLine("********* Sistema Shopping ************");
                    Console.WriteLine("1 -> Informe endereço dos arquivos");
                    Console.WriteLine("2 -> Gravar e exportar a fatura para um arquivo");
                    Console.WriteLine("3 -> Sair do sistema");
                    Console.WriteLine("Digite a opção desejada:");

                    int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:

                            Console.WriteLine("Informe o endereço do arquivo da lista de produtos:");
                            listaProduto = ControladorListaProdutos.RetornarListaProduto(Console.ReadLine());

                            Console.WriteLine("Informe o endereço do arquivo da lista de descontos:");
                            listaDescontos = ControladorDesconto.RetornarListaDesconto(Console.ReadLine());

                            Console.WriteLine("Informe o endereço do arquivo da Ordem de compra:");
                            OrdemCompras = ControladorOrdemCompra.RetornarOrdemCompra(Console.ReadLine());

                            break;

                        case 2:
                            Console.WriteLine("Informe o endereço onde o arquivo invoices será salvo:");
                            ControladorFatura.GravarFatura(listaProduto, listaDescontos, OrdemCompras, Console.ReadLine());

                            break;

                        case 3:
                            Environment.Exit(0);

                            break;
                        default:

                            Console.Clear();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
