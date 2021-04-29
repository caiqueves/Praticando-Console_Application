
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.CaiqueNeves.Entidade;
using Desafio.CaiqueNeves.Controlador;
using System.Configuration;

namespace Desafio.CaiqueNeves
{
    public class Program
    {
        static ListaProduto listaProduto = new ListaProduto();
        static List<Desconto> listaDescontos = new List<Desconto>();
        static OrdemCompra OrdemCompras = new OrdemCompra();
        static Fatura fatura = new Fatura();
        static ControladorFatura controladorFatura = new ControladorFatura();

        public static void Main(string[] args)
        {
            try
            {
                menuSistemaShopping();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Metodo responsavel por fazer o controle da opção selecionada pelo usuario
        /// </summary>
        
        private static void menuSistemaShopping()
        {
            string cond = "executar";
            while (cond != "parar")
            {
                Console.WriteLine("********* Sistema Shopping ************");
                Console.WriteLine("1 -> Informe endereço dos arquivos");
                Console.WriteLine("2 -> Solicitar geração da fatura");
                Console.WriteLine("3 -> Exportar a fatura para um arquivo");
                Console.WriteLine("4 -> Sair do sistema");
                Console.WriteLine("Digite a opção desejada:");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Informe o endereço do arquivo da lista de produtos:");
                        RetornarListaProduto(Console.ReadLine());

                        Console.WriteLine("Informe o endereço do arquivo da lista de descontos:");
                        listaDescontos = RetornarListaDesconto(Console.ReadLine());

                        Console.WriteLine("Informe o endereço do arquivo da Ordem de compra:");
                        OrdemCompras = RetornarListaOrdemCompra(Console.ReadLine());

                        break;
                    case 2:
                        fatura = RetornarFatura(listaProduto, listaDescontos, OrdemCompras);

                        break;
                    case 3:

                        Console.WriteLine("Informe o endereço onde o arquivo invoices será salvo:");
                        GravarArquivoFatura(fatura, Console.ReadLine());

                        break;
                    case 4:
                        Environment.Exit(0);

                        break;
                    default:

                        Console.Clear();
                        break;
                }
            }
        }


        #region Chamada dos controladores

        /// <summary>
        ///  Metodo que vai retornar o produtos contidos no arquivo 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Retornar um objeto com os dados do produto</returns>
        private static ListaProduto RetornarListaProduto(string path)
        {
            ControladorListaProdutos controladorListaProdutos = new ControladorListaProdutos();
            listaProduto = controladorListaProdutos.LeituraArquivoProduto(path);
            return listaProduto;
        }

        /// <summary>
        ///  Metodo que vai retornar os desconto contidos no arquivo 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Retornar uma lista de descontos</returns>
        private static List<Desconto> RetornarListaDesconto(string path)
        {
            ControladorDesconto controladorDesconto = new ControladorDesconto();
            listaDescontos = controladorDesconto.RetornarListaDesconto(path);
            return listaDescontos;
        }

        private static OrdemCompra RetornarListaOrdemCompra(string path)
        {
            ControladorOrdemCompra controladorOrdemCompra = new ControladorOrdemCompra();
            OrdemCompras = controladorOrdemCompra.LeituraArquivoOrdemCompra(path);
            return OrdemCompras;
        }

        private static Fatura RetornarFatura(ListaProduto listaProduto, List<Desconto> listaDescontos, OrdemCompra OrdemCompras)
        {
            fatura = controladorFatura.RetornarFaturas(listaProduto,listaDescontos,OrdemCompras);
            return fatura;
        }

        private static int GravarArquivoFatura(Fatura fatura, string path)
        {
            return controladorFatura.GravarArquivo(fatura, path);
        }

        #endregion
    }
}
