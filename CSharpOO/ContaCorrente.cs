using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public class ContaCorrente
    {
        int agencia;
        public int Agencia {
            get { return agencia;  }
            private set { if (value > 0)
                    agencia = value;
            }
        }

        int numeroConta;
        decimal saldo;
        decimal taxaMovimento;

        /**
         * decrementa o saldo.
         * */
        void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        /**
         * INcrementa o saldo*/
        void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}
