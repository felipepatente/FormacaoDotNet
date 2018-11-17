using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] contas = new ContaCorrente[] 
            {
                new ContaCorrente(874, 565555),
                new ContaCorrente(874, 251445),
                new ContaCorrente(874, 362555)
            };
                    
            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }

        }

        static void TestarArrayInt()
        {
            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                Console.WriteLine($"Acessando o array idades no índice {idades[indice]}");
                acumulador += idades[indice];
            }

            int media = acumulador / idades.Length;

            Console.WriteLine("Média: " + media);
        }
    }
}
