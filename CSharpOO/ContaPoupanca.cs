using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public class ContaPoupanca
    {
        int agencia;
        int conta;
        decimal saldo;

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
