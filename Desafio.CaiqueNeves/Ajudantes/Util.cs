using Desafio.CaiqueNeves.Entidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.CaiqueNeves.Ajudantes
{
    public static class Util
    {
        /// <summary>
        /// Metodo Responsavel por fazer a leitura do arquivo txt
        /// </summary>
        /// <param name="path"></param>
        /// <returns> Esse metodo vai retornar um arry de string contendo as linhas do arquivo</returns>
        public static List<String> LerArquivo(string path)
        {
            try
            {
                return System.IO.File.ReadAllLines(path).ToList();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static int GravarArquivo(Fatura fatura, string path)
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

                using (StreamWriter writer = new StreamWriter(pathArquivo, true))
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
