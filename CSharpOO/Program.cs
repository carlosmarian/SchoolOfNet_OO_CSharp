using System;

namespace CSharpOO
{
    class MinhaException : Exception
    {

        public Exception MensagemErro()
        {
            return new Exception("Erro da minha excpetion");
        }

        public Exception MensagemErro(string mensagem)
        {
            return new Exception(mensagem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;

                if (b == 0)
                    throw new MinhaException().MensagemErro("B não pode ser zero.");

                int rs = a / b;

                Console.WriteLine(rs);

                int[] vetor = new int[] { 1, 2, 4 };

                Console.WriteLine(vetor[1]);

            }
            catch (MinhaException ex)
            {
                Console.WriteLine(string.Format("Erro, minha Exception: {0}", ex.Message));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(string.Format("Erro, indice fora do limite: {0}", ex.Message));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(string.Format("erro, divisão por zero: {0}", ex.Message));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Erro, {0} ({1})", ex.Message, ex.GetType()));
            }
            finally
            {
                Console.WriteLine("Fim de execução;");
            }
            //ContaCorrente cc = new ContaCorrente();
            //cc.Depositar(1000);
            //cc.Sacar(200);
            //Console.WriteLine(cc.Saldo);

            //ContaPoupanca cp = new ContaPoupanca();
            //cp.Depositar(1000);
            //cp.Sacar(200);
            //Console.WriteLine(cp.Saldo);

            //Relatorio rel = new Relatorio();

            //rel.Somar(cc);
            //rel.Somar(cp);
            //Console.WriteLine(rel.SaldoGeral);

            //rel.SomarValor(1);
            //Console.WriteLine(rel.SaldoGeral);

            //rel.SomarValor(10, 20);
            //Console.WriteLine(rel.SaldoGeral);

            //rel.SomarTributo(cp);
            //Console.WriteLine(rel.TributoGeral);

            //Aguarda
            Console.ReadLine();
        }
    }
}