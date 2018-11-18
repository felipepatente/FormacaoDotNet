
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
        
        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo,FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(fluxoDeArquivo,Encoding.UTF8))
                {
                    escritor.Write("465, 65445,456.0,Leticia");
                }

            }            
        }  
        
        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {

                    for (int i = 0; i < 10000; i++)
                    {
                        escritor.WriteLine($"Linha {i}");
                        escritor.Flush(); //Despeja o buffer para o stream
                    }
                    
                }
            }
        }     
    }
}
