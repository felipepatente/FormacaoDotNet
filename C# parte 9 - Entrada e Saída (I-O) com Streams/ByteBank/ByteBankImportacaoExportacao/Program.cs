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
        static void Main(string[] args)             
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (StreamReader leitor = new StreamReader(fluxoDeArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        string linha = leitor.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            
            }
        }
        
    }
} 
 