using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar");



            }
            else if (quantidadePessoas >= 2)
            {
                Console.WriteLine("Jão não possui mais de 18 anos, mas está acompanhado");
            }
            else
            {
                Console.WriteLine("João nao possui mais de 18 anos, não pode entrar");
            }
        }
    }
}