﻿using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.Depositar(1000);
            cc.Sacar(200);
            Console.WriteLine(cc.Saldo);

            ContaPoupanca cp = new ContaPoupanca();
            cp.Depositar(1000);
            cp.Sacar(200);
            Console.WriteLine(cp.Saldo);

            Relatorio rel = new Relatorio();

            rel.Somar(cc);
            rel.Somar(cp);
            Console.WriteLine(rel.SaldoGeral);

            rel.SomarValor(1);
            Console.WriteLine(rel.SaldoGeral);

            rel.SomarValor(10, 20);
            Console.WriteLine(rel.SaldoGeral);


            //Aguarda
            Console.ReadLine();
        }
    }
}