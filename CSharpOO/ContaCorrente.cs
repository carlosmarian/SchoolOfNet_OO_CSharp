namespace CSharpOO
{
    public class ContaCorrente : Conta
    {
        decimal taxaMovimento;

        public decimal TaxaMovimento { get => taxaMovimento; set => taxaMovimento = value; }

        public ContaCorrente() : base(999)
        {
            this.TaxaMovimento = 0.1m;
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (this.taxaMovimento * valor));
        }
    }
}
