using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();

            Console.WriteLine(cc.Agencia);
            cc.Agencia = -1;
            Console.WriteLine(cc.Agencia);

            Console.ReadLine();
        }
    }
}