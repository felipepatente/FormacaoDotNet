using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente carlos = new Cliente();
            carlos.Nome = "Carlos";
            carlos.CPF = "145.336.212-23";
            carlos.Profissao = "Design";

            Cliente carlos2 = new Cliente();
            carlos2.Nome = "Carlos";
            carlos2.CPF = "145.336.212-23";
            carlos2.Profissao = "Design";

            ContaCorrente conta3 = new ContaCorrente(25, 362);

            if (carlos.Equals(conta3))
            {
                Console.WriteLine("São iguais");
            }else
            {
                Console.WriteLine("Não são iguais");
            }


            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";            
            //string padrao = "[0-9]{4,5}[-][0-9]{4}";            
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Felipe, me ligue em 96254-4256";

            Match resultado = Regex.Match(textoDeTeste, padrao);
            object conta = new ContaCorrente(20,14);

            Console.WriteLine(conta);

            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));            
            Console.WriteLine(resultado.Value);
            
            string urlParametros = "http:www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";
            int indice = palavra.IndexOf(nomeArgumento);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));
            
        }
    }


}
