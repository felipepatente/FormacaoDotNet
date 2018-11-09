using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(4000, cpf)
        {
        }
        
        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }
        
        public override double GetBonificiacao()
        {
            return Salario * 0.25;
        }
    }
}
