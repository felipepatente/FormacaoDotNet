using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBanck
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public ContaCorrente()
        {

        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

    }
}
