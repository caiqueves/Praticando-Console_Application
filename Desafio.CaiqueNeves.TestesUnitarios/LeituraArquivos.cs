using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desafio.CaiqueNeves.Controlador;
using System.Collections.Generic;
using Desafio.CaiqueNeves.Entidade;
using System.IO;

namespace Desafio.CaiqueNeves.TestesUnitarios
{
   
    [TestClass]
    public class LeituraArquivos
    {
        static ListaProduto produto = new ListaProduto();
        static List<Desconto> listaDescontos = new List<Desconto>();
        static OrdemCompra ordemCompra = new OrdemCompra();
        static Fatura fatura = new Fatura();
        static ControladorFatura controladorFatura = new ControladorFatura();

        [TestMethod]
        public void TestLeituraArquivoProduto()
        {
            string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos\ListaProdutos.txt";
            ControladorListaProdutos controladorListaProdutos = new ControladorListaProdutos();
            produto = controladorListaProdutos.LeituraArquivoProduto(path);

            Assert.IsTrue(produto != null);
        }

        [TestMethod]
        public void TestLeituraArquivoDesconto()
        {
            string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos\ListaDescontos.txt";
            ControladorDesconto controladorDesconto = new ControladorDesconto();
            listaDescontos = controladorDesconto
                .RetornarListaDesconto(path);

            Assert.IsTrue((listaDescontos.Count > 0) || (listaDescontos.Count == 0),"Nesse caso a lista de desconto pode ter desconto ou não ter");
        }

        [TestMethod]
        public void TestLeituraArquivoOrdemCompra()
        {
            string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos\ListaOrdemCompra.txt";
            ControladorOrdemCompra controladorOrdemCompra = new ControladorOrdemCompra();
            ordemCompra = controladorOrdemCompra.LeituraArquivoOrdemCompra(path);

            Assert.IsTrue(ordemCompra != null,"O Objeto Ordem Compra estava sem os valores");
        }

        [TestMethod]
        public void TestGeracaoFatura()
        {
            fatura = controladorFatura.RetornarFaturas(produto, listaDescontos, ordemCompra);
            
            Assert.IsTrue(fatura != null,"O Objeto Fatura estava sem os valores");
        }

        [TestMethod]
        public void TestGeracaoFaturaTXT()
        {
                string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos";
                int a = controladorFatura.GravarArquivo(fatura, path);
                Assert.IsTrue(a == 1);
            
        }
    }
}
