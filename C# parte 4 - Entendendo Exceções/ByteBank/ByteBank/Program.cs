using System;
using System.Collections.Generic;
using System.IO;
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
                CarregarContas();
            }
            catch (Exception e)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }
            
        }

        private static void CarregarContas()
        {

            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //---------------------------------------------------------------------------------------------------
            //LeitorDeArquivos leitor = null;

            //try
            //{

            //    leitor = new LeitorDeArquivos("Contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //    leitor.Fechar();
            //}            
            //finally
            //{
            //    Console.WriteLine("Executando o Finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(1000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
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

            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
            
        }
    }
}
