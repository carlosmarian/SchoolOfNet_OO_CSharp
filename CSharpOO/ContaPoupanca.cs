using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public class ContaPoupanca
    {
        private int agencia;
        private int conta;
        private decimal saldo;

        void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}
