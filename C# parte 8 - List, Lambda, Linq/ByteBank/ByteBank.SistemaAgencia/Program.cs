using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            var conta = new ContaCorrente(344, 45582);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();

            conta.Depositar(2514);









            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(45,36,25,14);

            for (int i = 0; i < idades.Count; i++)
            {                
                Console.WriteLine(idades[i]);
            }
            
        }        
    }
}
