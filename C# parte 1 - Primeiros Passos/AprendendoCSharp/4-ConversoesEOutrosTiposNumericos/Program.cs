using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario = 1200.50;

            //O int é uma variável que suporta valores de até 32 bits
            int salarioEmInterio = (int) salario;

            //O long é uma variavel de 64 bits
            long idade = 1300000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variavel de 16 bits
            short quantidadesProdutos = 15000;
            Console.WriteLine(quantidadesProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine(salarioEmInterio);
        }
    }
}
