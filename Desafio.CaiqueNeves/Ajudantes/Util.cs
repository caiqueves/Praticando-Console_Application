using System;
using System.Collections.Generic;
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
    }
}
