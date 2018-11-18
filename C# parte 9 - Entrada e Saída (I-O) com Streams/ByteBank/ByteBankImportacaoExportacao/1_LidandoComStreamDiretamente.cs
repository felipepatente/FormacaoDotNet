using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComFileStreamDiretamente()
        {
            string enderecoDoArquivo = "contas.txt";

            using (FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                byte[] buffer = new byte[1024]; // 1kb
                int numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;
            string texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.WriteLine(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.WriteLine(" ");
            //}

        }

    }
}
