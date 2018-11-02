﻿using _06_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBanck
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int numero { get; set; }
        private double _saldo = 100;
        
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
