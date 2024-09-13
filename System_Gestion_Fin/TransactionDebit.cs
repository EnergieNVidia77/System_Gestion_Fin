namespace Program
{
    public class TransactionDebit : Transaction
    {
        public TransactionDebit(decimal montant, string description) : base(montant, TypeTransaction.Debit, description) { }
        public override decimal appliquer(decimal solde)
        {
            return solde - Montant;
        }
    }
}