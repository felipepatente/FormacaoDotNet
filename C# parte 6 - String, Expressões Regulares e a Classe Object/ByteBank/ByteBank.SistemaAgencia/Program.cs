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
