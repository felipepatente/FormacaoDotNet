﻿using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args)             
        {
            string enderecoDoArquivo = "contas.txt";
            FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo,FileMode.Open);

            byte[] buffer = new byte[1024]; // 1kb
            int numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);                
            }

            EscreverBuffer(buffer);
        }

        static void EscreverBuffer(byte[] buffer)
        {

            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] != 0)
                {
                    Console.Write(buffer[i]);
                    Console.Write(" ");
                }
            }
            
        }













    }
} 
 