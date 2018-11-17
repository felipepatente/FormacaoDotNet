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
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            ListExtensoes.AdicionarVarios(idades, 1, 2555, 3655, 265);

            //idades.Remove(5);
            
            for (int i = 0; i < idades.Count; i++)
            {                
                Console.WriteLine(idades[i]);
            }
        }        
    }
}
