using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(String cpf) : base(5000, cpf)
        {

        }
        
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificiacao()
        {   
            return Salario + 0.5;
        }
    }
}
