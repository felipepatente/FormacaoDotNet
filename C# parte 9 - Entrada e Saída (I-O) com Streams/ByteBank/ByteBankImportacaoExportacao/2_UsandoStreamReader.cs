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
        static void TestarStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (StreamReader leitor = new StreamReader(fluxoDeArquivo, Encoding.Default))
                {
                    while (!leitor.EndOfStream)
                    {
                        string linha = leitor.ReadLine();
                        ContaCorrente contaCorrente = ConverterStringParaContaCorrente(linha);
                        string msg = $"{contaCorrente.Titular.Nome}: Conta número {contaCorrente.Numero} ag. {contaCorrente.Agencia}. Saldo {contaCorrente.Saldo}";

                        Console.WriteLine(msg);
                        //Console.WriteLine(linha);
                    }
                }

            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            int agencia = int.Parse(campos[0]);
            int numero = int.Parse(campos[1]);
            double saldo = double.Parse(campos[2].Replace('.', ','));
            string nomeTitular = campos[3];

            Cliente titular = new Cliente();
            titular.Nome = nomeTitular;

            ContaCorrente resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            resultado.Titular = titular;

            return resultado;
        }

    }
}
