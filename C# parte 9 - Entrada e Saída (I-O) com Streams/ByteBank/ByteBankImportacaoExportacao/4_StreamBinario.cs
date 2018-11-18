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
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt",FileMode.Create))
            {
                using (var escritor = new BinaryWriter(fs))
                {
                    escritor.Write(456);//número da Agência
                    escritor.Write(4562145); //número da conta
                    escritor.Write(4000.50); //saldo
                    escritor.Write("Felipe"); //Titular
                }
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt",FileMode.Open))
            {
                using (var leitor = new BinaryReader(fs))
                {
                    int agencia = leitor.ReadInt32();
                    int numeroConta = leitor.ReadInt32();
                    double saldo = leitor.ReadDouble();
                    string titular = leitor.ReadString();

                    Console.WriteLine($"{agencia}/{numeroConta}/{saldo}/{titular}");
                }
            }
        }
    }
}
