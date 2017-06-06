﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public class ContaCorrente
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;

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
