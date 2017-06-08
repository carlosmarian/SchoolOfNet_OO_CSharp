﻿using System;

namespace CSharpOO
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca() : base(900) 
        {
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}
