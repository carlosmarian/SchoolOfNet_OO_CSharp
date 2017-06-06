using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();

            Console.WriteLine(cc.Agencia);
            cc.Agencia = 111;
            Console.WriteLine(cc.Agencia);

            ContaPoupanca cp = new ContaPoupanca();
            cp.Agencia = 321;
            Console.WriteLine(cp.Agencia);

            Console.ReadLine();
        }
    }
}