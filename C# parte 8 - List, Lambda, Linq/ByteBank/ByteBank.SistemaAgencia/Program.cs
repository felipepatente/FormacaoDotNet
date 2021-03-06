﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341,5264),                
                new ContaCorrente(342,5274), 
                null,               
                new ContaCorrente(324,5284),
                null,
                new ContaCorrente(314,5214)                
            };

            var contasNaoNulas = contas.Where(conta => conta != null);

            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
                contasNaoNulas.OrderBy(conta => conta.Numero );
            
            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");                            
            }

        }   
        
        static void TestarSort()
        {
            var nomes = new List<string>()
            {
                "Yasmin",
                "Felipe",
                "Juliana",
                "Leticia",
                "Jéssica",
                "Monique",
                "Aline"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(45, 36, 25, 14);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }     
    }
}
