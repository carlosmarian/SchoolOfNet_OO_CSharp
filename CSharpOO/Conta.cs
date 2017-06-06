using System;

namespace CSharpOO
{
    public class Conta
    {
        int agencia;
        int numeroConta;
        decimal saldo;
        decimal limite;

        public int Agencia
        {
            get { return agencia; }
            set
            {
                if (value > 0)
                    agencia = value;
            }
        }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public decimal Limite { get => limite; set => limite = value; }

        public Conta()
        {
            this.limite = 1000;
        }

        public Conta(decimal limite)
        {
            this.limite = limite;
        }

        /**
         * decrementa o saldo.
         * */
        void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        /**
         * INcrementa o saldo*/
        void Depositar(decimal valor)
        {
            Saldo += valor;
        }

    }
}
