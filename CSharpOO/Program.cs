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
            Console.WriteLine(cc.Limite);

            ContaPoupanca cp = new ContaPoupanca();
            cp.Agencia = 321;
            Console.WriteLine(cp.Limite);
            Console.WriteLine(cp.Agencia);

            Console.ReadLine();
        }
    }
}