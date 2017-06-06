using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 1000;
            cc.Sacar(200);
            Console.WriteLine(cc.Saldo);

            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 1000;
            cp.Sacar(200);
            Console.WriteLine(cp.Saldo);

            Console.ReadLine();
        }
    }
}