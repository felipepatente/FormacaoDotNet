using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alura.ListaLeitura.App.HTML
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHTML(string nomeArquivo)
        {
            using (var arquivo = File.OpenText($"{nomeArquivo}.html"))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
