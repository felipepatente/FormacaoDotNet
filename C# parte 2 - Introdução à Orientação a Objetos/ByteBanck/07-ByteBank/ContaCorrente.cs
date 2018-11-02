using _07_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBanck
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas {get; private set;}
        private int _agencia;        
        public int Numero { get; set; }
        private double _saldo = 100;
        
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public static int ObterTotalDeContasCriadas()
        {
            return TotalDeContasCriadas;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }
        
        public int Agencia {

            get
            {
                return _agencia;
            }

            set
            {
                if (value <= 0)
                {
                    return;
                }

                this._agencia = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);

                return true;
            }
        }

    }
}
