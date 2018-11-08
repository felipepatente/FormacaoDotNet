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

            Funcionario carlos = new Funcionario(200,"546.879.157-20");

            carlos.Nome = "Carlos";            
            
            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Funcionario pedro = new Diretor("454.658.148-3");

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";            
            
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário de Roberta " + roberta.Salario);

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificiacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificiacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificiacao());
        }
    }
}
