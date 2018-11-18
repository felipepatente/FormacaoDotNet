
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(FileStream fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                string contaComoString = "456,78945,4785.50,Gustavo Santos";
                var enconding = Encoding.UTF8;
                var bytes = enconding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }        
    }
}
