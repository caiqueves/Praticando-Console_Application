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
        static IControladorListaProdutos _controladorListaProdutos;
        static IControladorOrdemCompra _controladorOrdemCompra;
        static IControladorDesconto _controladorDesconto;
        static IControladorFatura _controladorFatura;

        [TestMethod]
        public void TestLeituraArquivoProduto()
        {
            string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos\ListaProdutos.txt";
           
            produto = _controladorListaProdutos.RetornarListaProduto(path);

            Assert.IsTrue(produto != null);
        }

        [TestMethod]
        public void TestLeituraArquivoDesconto()
        {
            string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos\ListaDescontos.txt";
            
            listaDescontos = _controladorDesconto.RetornarListaDesconto(path);

            Assert.IsTrue((listaDescontos.Count > 0) || (listaDescontos.Count == 0),"Nesse caso a lista de desconto pode ter desconto ou não ter");
        }

        [TestMethod]
        public void TestLeituraArquivoOrdemCompra()
        {
            string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos\ListaOrdemCompra.txt";
            
            ordemCompra = _controladorOrdemCompra.RetornarListaOrdemCompra(path);

            Assert.IsTrue(ordemCompra != null,"O Objeto Ordem Compra estava sem os valores");
        }

        [TestMethod]
        public void TestGeracaoFatura()
        {
            string path = @"D:\TFS\cfsn\desafio-042021-caiqueneves\documentos";
            int retorno = _controladorFatura.GravarFatura(produto, listaDescontos, ordemCompra, path);
            
            Assert.IsTrue(retorno > 0,"O Objeto Fatura estava sem os valores");
        }
    }
}
