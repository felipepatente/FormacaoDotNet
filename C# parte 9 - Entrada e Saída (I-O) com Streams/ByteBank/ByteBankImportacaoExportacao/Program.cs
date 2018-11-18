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
            File.WriteAllText("escrevendo.txt", "Testando");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            string[] linhas = File.ReadAllLines("contas.txt");

            Console.WriteLine(linhas.Length);

            foreach (var item in linhas)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("Digite seu nome: ");
            //var nome = Console.ReadLine();

            //Console.WriteLine(nome);

            //UsarStreamDeEntrada();
            Console.WriteLine("Aplicação Finalizada");
        }            
    }
} 
 