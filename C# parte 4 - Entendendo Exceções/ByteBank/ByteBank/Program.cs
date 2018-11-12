﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }

        }

        private static void Metodo()
        {
            TestaDivisao(0);            
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é de " + resultado);            
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;

            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}
