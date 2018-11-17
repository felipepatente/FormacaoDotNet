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
            ListaObject listaDeIdades = new ListaObject();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 26, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = Convert.ToInt32(listaDeIdades[i]);
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static void TestarListaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDoGui = new ContaCorrente(874, 565555);


            lista.Adicionar(new ContaCorrente(874, 565555));
            lista.Adicionar(new ContaCorrente(874, 251432));

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 251432),
                new ContaCorrente(874, 525145),
                new ContaCorrente(874, 362511),
                new ContaCorrente(874, 152465),
                new ContaCorrente(874, 256885),
                new ContaCorrente(874, 158822),
                new ContaCorrente(874, 152466)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                new ContaCorrente(874, 251432),
                new ContaCorrente(872, 525145),
                new ContaCorrente(871, 362511),
                new ContaCorrente(870, 152465),
                new ContaCorrente(177, 256885),
                new ContaCorrente(374, 158822),
                new ContaCorrente(474, 152466)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAutal = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAutal.Numero} / Agência {itemAutal.Agencia}");
            }
        }

        static void TestaArrayContaCorrente()
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
