using ByteBank.Funcionarios;
using System;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Funcionario pedro = new Diretor();

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificiacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificiacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificiacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.Salario);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificiacao());
        }
    }
}
